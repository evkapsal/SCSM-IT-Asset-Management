﻿#pragma checksum "..\..\MobileDeviceForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63B67CB10D244BC7FA54F15AA5824DB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ITAssetMgmtForms;
using Microsoft.EnterpriseManagement.UI.FormsInfra;
using Microsoft.EnterpriseManagement.UI.WpfControls;
using Microsoft.EnterpriseManagement.UI.WpfToolbox;
using Microsoft.Windows.Controls;
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


namespace ITAssetMgmtForms {
    
    
    /// <summary>
    /// MobileDeviceForm
    /// </summary>
    public partial class MobileDeviceForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\MobileDeviceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemGeneral;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MobileDeviceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expMain;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\MobileDeviceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemRelItems;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\MobileDeviceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/ITAssetMgmtForms;component/mobiledeviceform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MobileDeviceForm.xaml"
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
            
            #line 14 "..\..\MobileDeviceForm.xaml"
            ((ITAssetMgmtForms.MobileDeviceForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tabItemGeneral = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.expMain = ((System.Windows.Controls.Expander)(target));
            
            #line 99 "..\..\MobileDeviceForm.xaml"
            this.expMain.Loaded += new System.Windows.RoutedEventHandler(this.expMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 122 "..\..\MobileDeviceForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 150 "..\..\MobileDeviceForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 181 "..\..\MobileDeviceForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tabItemRelItems = ((System.Windows.Controls.TabItem)(target));
            return;
            case 8:
            this.tabItemHistory = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
