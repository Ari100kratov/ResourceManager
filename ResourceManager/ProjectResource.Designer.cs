﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResourceManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ProjectResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ProjectResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ResourceManager.ProjectResource", typeof(ProjectResource).Assembly);
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
        ///   Looks up a localized string similar to Не удалось создать резервную копию.\nУбедитесь в корректности указанного пути.
        /// </summary>
        internal static string BackupError {
            get {
                return ResourceManager.GetString("BackupError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вы хотите сделать резервную копию изменяемого файла?.
        /// </summary>
        internal static string ConfirmCreateBackup {
            get {
                return ResourceManager.GetString("ConfirmCreateBackup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Резервное копирование.
        /// </summary>
        internal static string CreateBackup_Dialog_Header {
            get {
                return ResourceManager.GetString("CreateBackup_Dialog_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка.
        /// </summary>
        internal static string ErrorMessage_Caption {
            get {
                return ResourceManager.GetString("ErrorMessage_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Сообщение.
        /// </summary>
        internal static string InformationMessage_Caption {
            get {
                return ResourceManager.GetString("InformationMessage_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не выбран ресурс.
        /// </summary>
        internal static string ResourceNotSelected {
            get {
                return ResourceManager.GetString("ResourceNotSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Клиент.
        /// </summary>
        internal static string SourceEnumExtension_ToLocalString_Client {
            get {
                return ResourceManager.GetString("SourceEnumExtension_ToLocalString_Client", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Сервер.
        /// </summary>
        internal static string SourceEnumExtension_ToLocalString_Server {
            get {
                return ResourceManager.GetString("SourceEnumExtension_ToLocalString_Server", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Данные успешно сохранены.
        /// </summary>
        internal static string SuccessSave {
            get {
                return ResourceManager.GetString("SuccessSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Внимание!.
        /// </summary>
        internal static string WarningMessage_Caption {
            get {
                return ResourceManager.GetString("WarningMessage_Caption", resourceCulture);
            }
        }
    }
}