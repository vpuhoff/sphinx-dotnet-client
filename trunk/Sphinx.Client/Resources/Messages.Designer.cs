﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sphinx.Client.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sphinx.Client.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DateTime value can&apos;t be before Unix Epoch (1 Jan 1970 00:00:00 UTC) and after Unix Millenium (19 January 2038 03:14:07 UTC) .
        /// </summary>
        internal static string Exception_ArgumentDateTimeOutOfRangeUnixTimestamp {
            get {
                return ResourceManager.GetString("Exception_ArgumentDateTimeOutOfRangeUnixTimestamp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is empty.
        /// </summary>
        internal static string Exception_ArgumentIsEmpty {
            get {
                return ResourceManager.GetString("Exception_ArgumentIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of &apos;{0}&apos; argument is not a valid value of the enumeration type &apos;{1}&apos;.
        /// </summary>
        internal static string Exception_ArgumentIsNotDefinedInEnum {
            get {
                return ResourceManager.GetString("Exception_ArgumentIsNotDefinedInEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is null.
        /// </summary>
        internal static string Exception_ArgumentIsNull {
            get {
                return ResourceManager.GetString("Exception_ArgumentIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MinDocumentId property value must be less or equal to MaxDocumentId property value.
        /// </summary>
        internal static string Exception_ArgumentMinIdGreaterThanMaxId {
            get {
                return ResourceManager.GetString("Exception_ArgumentMinIdGreaterThanMaxId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be greater than or equal to {0}.
        /// </summary>
        internal static string Exception_ArgumentMustBeGreaterOrEqual {
            get {
                return ResourceManager.GetString("Exception_ArgumentMustBeGreaterOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be greater than {0}.
        /// </summary>
        internal static string Exception_ArgumentMustBeGreaterThan {
            get {
                return ResourceManager.GetString("Exception_ArgumentMustBeGreaterThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be in range {0} to {1}.
        /// </summary>
        internal static string Exception_ArgumentMustBeInRange {
            get {
                return ResourceManager.GetString("Exception_ArgumentMustBeInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be less than or equal to {0}.
        /// </summary>
        internal static string Exception_ArgumentMustBeLessOrEqual {
            get {
                return ResourceManager.GetString("Exception_ArgumentMustBeLessOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be less than {0}.
        /// </summary>
        internal static string Exception_ArgumentMustBeLessThan {
            get {
                return ResourceManager.GetString("Exception_ArgumentMustBeLessThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SortBy property can not be empty in selected sorting mode &apos;{0}&apos;.
        /// </summary>
        internal static string Exception_ArgumentResultsSortModeNotValid {
            get {
                return ResourceManager.GetString("Exception_ArgumentResultsSortModeNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unix timestamp value is out of range (signed int).
        /// </summary>
        internal static string Exception_ArgumentUnixTimestampOutOfRange {
            get {
                return ResourceManager.GetString("Exception_ArgumentUnixTimestampOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified binary format type &apos;{0}&apos; is unknown or not supported.
        /// </summary>
        internal static string Exception_BinaryFormatNotSupported {
            get {
                return ResourceManager.GetString("Exception_BinaryFormatNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input stream does not supports reading operations.
        /// </summary>
        internal static string Exception_CantReadFromStream {
            get {
                return ResourceManager.GetString("Exception_CantReadFromStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output stream does not supports writing operations.
        /// </summary>
        internal static string Exception_CantWriteToStream {
            get {
                return ResourceManager.GetString("Exception_CantWriteToStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation not allowed on non-connected client sockets.
        /// </summary>
        internal static string Exception_ClientSocketNotConnected {
            get {
                return ResourceManager.GetString("Exception_ClientSocketNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sphinx server command version {0}.{1} older than version {2}.{3} supported by client, some features might not work as expected.
        /// </summary>
        internal static string Exception_CommandVersion {
            get {
                return ResourceManager.GetString("Exception_CommandVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not flush attribute values. Server returned negative flash tag value: {0}.
        /// </summary>
        internal static string Exception_CouldNotFlushIndexAttributeValues {
            get {
                return ResourceManager.GetString("Exception_CouldNotFlushIndexAttributeValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read from stream. Requested {0} bytes, actually received {1} bytes.
        /// </summary>
        internal static string Exception_CouldNotReadFromStream {
            get {
                return ResourceManager.GetString("Exception_CouldNotReadFromStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not update attribute values in specified index list. Server returned updated documents count: {0}.
        /// </summary>
        internal static string Exception_CouldNotUpdateIndexAttributeValues {
            get {
                return ResourceManager.GetString("Exception_CouldNotUpdateIndexAttributeValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid server response length: {0}.
        /// </summary>
        internal static string Exception_InvalidServerResponseLength {
            get {
                return ResourceManager.GetString("Exception_InvalidServerResponseLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream object is null.
        /// </summary>
        internal static string Exception_IOStreamDisposed {
            get {
                return ResourceManager.GetString("Exception_IOStreamDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Underlying network connection was closed or timed out.
        /// </summary>
        internal static string Exception_NetworkConnectionIsUnavailable {
            get {
                return ResourceManager.GetString("Exception_NetworkConnectionIsUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported Sphinx server protocol version {1}, expected version {0} or higher.
        /// </summary>
        internal static string Exception_ProtocolVersionNotSupported {
            get {
                return ResourceManager.GetString("Exception_ProtocolVersionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sphinx server returned error status for query. Server message: &apos;{0}&apos;.
        /// </summary>
        internal static string Exception_QueryError {
            get {
                return ResourceManager.GetString("Exception_QueryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read timeout expired.
        /// </summary>
        internal static string Exception_ReadTimeoutExpired {
            get {
                return ResourceManager.GetString("Exception_ReadTimeoutExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sphinx server returned error, message: &apos;{0}&apos;.
        /// </summary>
        internal static string Exception_ServerError {
            get {
                return ResourceManager.GetString("Exception_ServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Temporary server error. Please try again later. 
        ///Server message: &apos;{0}&apos;..
        /// </summary>
        internal static string Exception_TemproraryServerError {
            get {
                return ResourceManager.GetString("Exception_TemproraryServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sphinx server returned unknown status code: {0}.
        /// </summary>
        internal static string Exception_UnknowStatusCode {
            get {
                return ResourceManager.GetString("Exception_UnknowStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported attribute type &apos;{0}&apos;.
        /// </summary>
        internal static string Exception_UnsupportedAttributeType {
            get {
                return ResourceManager.GetString("Exception_UnsupportedAttributeType", resourceCulture);
            }
        }
    }
}
