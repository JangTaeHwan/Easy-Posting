﻿#pragma checksum "..\..\..\Pages\image_search.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C69017D8ADEACDF8734E5F4DD9F7BD61"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.34014
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Easy_Posting.Content {
    
    
    /// <summary>
    /// image_search
    /// </summary>
    public partial class image_search : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\image_search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serch_text;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\image_search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton serch;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\image_search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton insert;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\image_search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ImageListbox;
        
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
            System.Uri resourceLocater = new System.Uri("/Easy Posting;component/pages/image_search.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\image_search.xaml"
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
            this.serch_text = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Pages\image_search.xaml"
            this.serch_text.KeyDown += new System.Windows.Input.KeyEventHandler(this.serch_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.serch = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 23 "..\..\..\Pages\image_search.xaml"
            this.serch.Click += new System.Windows.RoutedEventHandler(this.serch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.insert = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 25 "..\..\..\Pages\image_search.xaml"
            this.insert.Click += new System.Windows.RoutedEventHandler(this.insert_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImageListbox = ((System.Windows.Controls.ListBox)(target));
            
            #line 29 "..\..\..\Pages\image_search.xaml"
            this.ImageListbox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageListbox_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

