﻿#pragma checksum "..\..\CheckBalance.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ABEF21CD4384D0B6045625ED549ADE1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace HisaabManagement {
    
    
    /// <summary>
    /// CheckBalance
    /// </summary>
    public partial class CheckBalance : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\CheckBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grduserbalance;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\CheckBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combouser;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CheckBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grduserbalance_detail;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CheckBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_distributedtxn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CheckBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_indivisualtxn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CheckBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_checkbalance;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CheckBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menu_totaltxn;
        
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
            System.Uri resourceLocater = new System.Uri("/HisaabManagement;component/checkbalance.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CheckBalance.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.grduserbalance = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.combouser = ((System.Windows.Controls.ComboBox)(target));
            
            #line 9 "..\..\CheckBalance.xaml"
            this.combouser.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combouser_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.grduserbalance_detail = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.menu_distributedtxn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\CheckBalance.xaml"
            this.menu_distributedtxn.Click += new System.Windows.RoutedEventHandler(this.menu_distributedtxn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.menu_indivisualtxn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\CheckBalance.xaml"
            this.menu_indivisualtxn.Click += new System.Windows.RoutedEventHandler(this.menu_indivisualtxn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menu_checkbalance = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\CheckBalance.xaml"
            this.menu_checkbalance.Click += new System.Windows.RoutedEventHandler(this.menu_checkbalance_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.menu_totaltxn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\CheckBalance.xaml"
            this.menu_totaltxn.Click += new System.Windows.RoutedEventHandler(this.menu_totaltxn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

