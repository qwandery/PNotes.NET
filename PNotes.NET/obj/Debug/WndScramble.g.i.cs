﻿#pragma checksum "..\..\WndScramble.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F48C4A5BF8ECDA70E2821EF3BBAC116E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PNotes.NET;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PNotes.NET {
    
    
    /// <summary>
    /// WndScramble
    /// </summary>
    public partial class WndScramble : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PNotes.NET.WndScramble DlgScramble;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblScramble;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwrdKey;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKey;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkSmtpShowPassword;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblScrambleWarning;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdOK;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\WndScramble.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PNotes.NET;component/wndscramble.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WndScramble.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DlgScramble = ((PNotes.NET.WndScramble)(target));
            
            #line 19 "..\..\WndScramble.xaml"
            this.DlgScramble.Loaded += new System.Windows.RoutedEventHandler(this.DlgScramble_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblScramble = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.pwrdKey = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 29 "..\..\WndScramble.xaml"
            this.pwrdKey.PasswordChanged += new System.Windows.RoutedEventHandler(this.pwrdKey_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtKey = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\WndScramble.xaml"
            this.txtKey.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtKey_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkSmtpShowPassword = ((System.Windows.Controls.CheckBox)(target));
            
            #line 31 "..\..\WndScramble.xaml"
            this.chkSmtpShowPassword.Checked += new System.Windows.RoutedEventHandler(this.chkSmtpShowPassword_Checked);
            
            #line default
            #line hidden
            
            #line 31 "..\..\WndScramble.xaml"
            this.chkSmtpShowPassword.Unchecked += new System.Windows.RoutedEventHandler(this.chkSmtpShowPassword_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblScrambleWarning = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.cmdOK = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\WndScramble.xaml"
            this.cmdOK.Click += new System.Windows.RoutedEventHandler(this.cmdOK_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmdCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
