﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magurany.Data.TableStorageClient.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Magurany.Data.TableStorageClient.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The connection is not open.
        /// </summary>
        internal static string ConnectionNotOpen {
            get {
                return ResourceManager.GetString("ConnectionNotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log Entry for log {0} at {1} by {2}: {3}.
        /// </summary>
        internal static string LogEntryToString {
            get {
                return ResourceManager.GetString("LogEntryToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expected parameter, &apos;{0},&apos; was not found..
        /// </summary>
        internal static string ParameterNotFound {
            get {
                return ResourceManager.GetString("ParameterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only &apos;{0}&apos; is supported..
        /// </summary>
        internal static string ParamterDirectionNotSupported {
            get {
                return ResourceManager.GetString("ParamterDirectionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument, &apos;{0},&apos; cannot be empty or contain only white spaces..
        /// </summary>
        internal static string ThrowArgumentEmpty {
            get {
                return ResourceManager.GetString("ThrowArgumentEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null..
        /// </summary>
        internal static string ThrowArgumentNull {
            get {
                return ResourceManager.GetString("ThrowArgumentNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument, &apos;{0},&apos; must be of type &apos;{1}.&apos;.
        /// </summary>
        internal static string ThrowArgumentWrongType {
            get {
                return ResourceManager.GetString("ThrowArgumentWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0}, &apos;{1},&apos; already exists..
        /// </summary>
        internal static string ThrowObjectExists {
            get {
                return ResourceManager.GetString("ThrowObjectExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0}, &apos;{1},&apos; was not found..
        /// </summary>
        internal static string ThrowObjectNotFound {
            get {
                return ResourceManager.GetString("ThrowObjectNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service of type, &apos;{0},&apos; was not found..
        /// </summary>
        internal static string ThrowServiceNotFound {
            get {
                return ResourceManager.GetString("ThrowServiceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Type, &apos;{0},&apos; is not supported..
        /// </summary>
        internal static string TypeNotSupported {
            get {
                return ResourceManager.GetString("TypeNotSupported", resourceCulture);
            }
        }
    }
}