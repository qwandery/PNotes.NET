﻿#pragma checksum "..\..\WndPasswordChange.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E80700F18C3E811873492DFB97143C00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PNScrollPanel;
using PNotes.NET;
using PNotes.NET.styles;
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
    /// WndPasswordChange
    /// </summary>
    public partial class WndPasswordChange : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PNotes.NET.WndPasswordChange DlgPasswordChange;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblOldPwrd;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtOldPwrd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblEnterPwrd;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtEnterPwrd;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblConfirmPwrd;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtConfirmPwrd;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WndPasswordChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdOK;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WndPasswordChange.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PNotes.NET;component/wndpasswordchange.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WndPasswordChange.xaml"
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
            this.DlgPasswordChange = ((PNotes.NET.WndPasswordChange)(target));
            
            #line 20 "..\..\WndPasswordChange.xaml"
            this.DlgPasswordChange.Loaded += new System.Windows.RoutedEventHandler(this.DlgPasswordChange_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblOldPwrd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtOldPwrd = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 32 "..\..\WndPasswordChange.xaml"
            this.txtOldPwrd.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtEnterPwrd_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblEnterPwrd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtEnterPwrd = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 34 "..\..\WndPasswordChange.xaml"
            this.txtEnterPwrd.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtEnterPwrd_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblConfirmPwrd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtConfirmPwrd = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 36 "..\..\WndPasswordChange.xaml"
            this.txtConfirmPwrd.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtEnterPwrd_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmdOK = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\WndPasswordChange.xaml"
            this.cmdOK.Click += new System.Windows.RoutedEventHandler(this.cmdOK_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmdCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
