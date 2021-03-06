﻿#pragma checksum "..\..\..\Reports\PaymentAdvice.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ECFB5D4CA1A4AA73072E43C5D273CEB770DD09D"
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
using ShortBody.Reports;
using ShortBody.Resources.Helper_Methods;
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


namespace ShortBody.Reports {
    
    
    /// <summary>
    /// PaymentAdvice
    /// </summary>
    public partial class PaymentAdvice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel TopPanel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentScrollViewer document;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel helperPanel;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteItem;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AdvicesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbVat;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbVatAmount;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSubTotal;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Reports\PaymentAdvice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTotal;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/reports/paymentadvice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Reports\PaymentAdvice.xaml"
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
            
            #line 10 "..\..\..\Reports\PaymentAdvice.xaml"
            ((ShortBody.Reports.PaymentAdvice)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TopPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 28 "..\..\..\Reports\PaymentAdvice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnPrint_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.document = ((System.Windows.Controls.FlowDocumentScrollViewer)(target));
            return;
            case 5:
            this.helperPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.btnDeleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\Reports\PaymentAdvice.xaml"
            this.btnDeleteItem.Click += new System.Windows.RoutedEventHandler(this.btnDeleteItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AdvicesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 113 "..\..\..\Reports\PaymentAdvice.xaml"
            this.AdvicesDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AdvicesDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 113 "..\..\..\Reports\PaymentAdvice.xaml"
            this.AdvicesDataGrid.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.AdvicesDataGrid_CellEditEnding);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbVat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbVatAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbSubTotal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.tbTotal = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

