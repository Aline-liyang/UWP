﻿#pragma checksum "C:\Users\Aline\Project_C#2\AppCours5\Page5Liaison.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A085FBF4DE2A89CD5F22C6137E0ECCF9C5F29DD5E22F262E199A85F5FB1B3FA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppCours5
{
    partial class Page5Liaison : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Page5Liaison.xaml line 15
                {
                    this.tbxPoids = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Page5Liaison.xaml line 18
                {
                    this.tbxTaille = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Page5Liaison.xaml line 20
                {
                    this.tbxIMC = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Page5Liaison.xaml line 21
                {
                    this.btnCalculer = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCalculer).Click += this.BtnCalculer_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
