﻿#pragma checksum "..\..\..\..\Windows\AddEntry.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80B33EFD969C2746D57D4F4C67273248621666AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PasswordManager.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PasswordManager.Windows {
    
    
    /// <summary>
    /// AddEntry
    /// </summary>
    public partial class AddEntry : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\..\Windows\AddEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbNewEntry;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Windows\AddEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNewEntry;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PasswordManager;component/windows/addentry.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddEntry.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pbNewEntry = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.tbNewEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 60 "..\..\..\..\Windows\AddEntry.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.aChangePass);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 69 "..\..\..\..\Windows\AddEntry.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.aAddEntry);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 70 "..\..\..\..\Windows\AddEntry.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.aBack);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 74 "..\..\..\..\Windows\AddEntry.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.aToPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
