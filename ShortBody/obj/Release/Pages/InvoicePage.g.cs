﻿#pragma checksum "..\..\..\Pages\InvoicePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D8C71E5BED4FA8BC32551F49D4CE2C16755250AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using ShortBody.Pages;
using ShortBody.Resources.Helper_Methods;
using ShortBody.Resources.UserControls;
using ShortBody.ValueConverters;
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


namespace ShortBody.Pages {
    
    
    /// <summary>
    /// InvoicePage
    /// </summary>
    public partial class InvoicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 33 "..\..\..\Pages\InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboInvoiceFor;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchBox;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Pages\InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.miniWindow AddInvoiceWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/pages/invoicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\InvoicePage.xaml"
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
            
            #line 14 "..\..\..\Pages\InvoicePage.xaml"
            ((ShortBody.Pages.InvoicePage)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Page_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboInvoiceFor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 40 "..\..\..\Pages\InvoicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllInvoices_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cboSearchBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\Pages\InvoicePage.xaml"
            this.cboSearchBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboSearchBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtSearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 80 "..\..\..\Pages\InvoicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 94 "..\..\..\Pages\InvoicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viewInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 100 "..\..\..\Pages\InvoicePage.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.InvoiceDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddInvoiceWindow = ((ShortBody.Resources.UserControls.miniWindow)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 107 "..\..\..\Pages\InvoicePage.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClientInvoices_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 108 "..\..\..\Pages\InvoicePage.xaml"
            ((System.Windows.Controls.DataGrid)(target)).PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.DataGrid_PreviewMouseWheel);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
