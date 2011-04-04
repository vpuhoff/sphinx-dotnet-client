#region Copyright
// 
// Copyright (c) 2009, Rustam Babadjanov <theplacefordev [at] gmail [dot] com>
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU Lesser General Public License version 2.1 as published
// by the Free Software Foundation.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
#endregion
#region Usings

using System.Collections.Generic;
using Sphinx.Client.Helpers;
using Sphinx.Client.IO;

#endregion

namespace Sphinx.Client.Commands.Attributes.Update
{

    /// <summary>
    /// Represents attribute multi-ordinal values and document IDs set to update.
    /// </summary>
    public class AttributeUpdateMultiOrdinal : AttributeUpdateBase, IAttributeValuesPerDocument<IList<int>>
    {
        #region Fields
        private readonly Dictionary<long, IList<int>> _values = new Dictionary<long, IList<int>>();
        
        #endregion

        #region Constructors
        internal AttributeUpdateMultiOrdinal()
        {

        }

        public AttributeUpdateMultiOrdinal(string name, IDictionary<long, IList<int>> values): base(name)
        {
            ArgumentAssert.IsNotEmpty(values, "values");
            CollectionUtil.UnionDictionaries(_values, values);
        }
        
        #endregion

        #region Properties
        public override AttributeType AttributeType
        {
            get { return AttributeType.MultiOrdinal; }
        }

        #region Implementation of IAttributeValuesPerDocument
        public IDictionary<long, IList<int>> Values
        {
            get { return _values; }
        }
        
        #endregion

        #endregion

        #region Methods
        internal override IEnumerable<long> GetDocumentsIdSet()
        {
            return new List<long>(Values.Keys);
        }

        internal override void Serialize(BinaryWriterBase writer, long id)
        {
            IList<int> values = Values[id];
            writer.Write(values.Count);
            foreach (int val in values)
            {
                writer.Write(val);
            }
        }

        #endregion

    }
}
