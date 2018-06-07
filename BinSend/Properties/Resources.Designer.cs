﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BinSend.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BinSend.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Address Book
        ///============
        ///
        ///Use this form to manage your address book
        ///
        ///Creating an Entry
        ///=================
        ///To create an entry, type the address and label into the text boxes and click &quot;Save&quot;.
        ///
        ///Editing an Entry
        ///================
        ///Select an entry from the list and then edit its label and click &quot;Save&quot;.
        ///You can&apos;t edit the address itself.
        ///If you modify the address it will create a new entry instead.
        ///
        ///Deleting an Entry
        ///=================
        ///Click on an Entry and then press the [DEL] key
        ///
        ///Selecting an  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HELP_AddrBook {
            get {
                return ResourceManager.GetString("HELP_AddrBook", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Main Window
        ///===========
        ///
        ///In this window you assemble your messages and access other functions
        ///
        ///From
        ///====
        ///Use this field to select the &quot;From&quot; address for your messages.
        ///This always contains two special values:
        ///
        ///- BM-SRND: This generates a new address and sends all parts from it
        ///- BM-MRND: This generates a new random address for each part
        ///
        ///You can generate addresses yourself using the button next to the select box
        ///
        ///To
        ///==
        ///This is the recipient.
        ///You can type/paste an address or select one from [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HELP_Main {
            get {
                return ResourceManager.GetString("HELP_Main", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Templates
        ///=========
        ///
        ///Use this Window to manage your Templates.
        ///
        ///Editing Templates
        ///=================
        ///In the left column you see a list of all templates.
        ///To edit the content and encoding, just select the template in question.
        ///Below the box are buttons to add, delete and reorder your templates.
        ///You can Edit the template with the text box on the right side.
        ///The encoding can be chosen from the drop down element on the bottom.
        ///
        ///The changes are remembered immediately and you can freely switch between  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HELP_Template {
            get {
                return ResourceManager.GetString("HELP_Template", resourceCulture);
            }
        }
    }
}
