﻿#pragma checksum "..\..\..\Pages\AddOrEditServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02F504EF5D4CB52E7F8BD691C62A8DB9C8F0D9FB38C6BDB4D7005E7F524218FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CarServiceApp.Pages;
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


namespace CarServiceApp.Pages {
    
    
    /// <summary>
    /// AddOrEditServicePage
    /// </summary>
    public partial class AddOrEditServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxTitle;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxCost;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxDuration;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxDescription;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxDiscount;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageService;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSelectImage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\AddOrEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/CarServiceApp;component/pages/addoreditservicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddOrEditServicePage.xaml"
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
            this.TBoxTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBoxCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBoxDuration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBoxDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBoxDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ImageService = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.BtnSelectImage = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\AddOrEditServicePage.xaml"
            this.BtnSelectImage.Click += new System.Windows.RoutedEventHandler(this.BtnSelectImage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\AddOrEditServicePage.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

