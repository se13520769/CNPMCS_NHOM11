﻿#pragma checksum "E:\GSOFT\Projects\Asset Management\WIP\Program\mvvmSilverlight\SilverlightProject1\Views\Common\SBBranch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "589A1F771458CF87E05DA4C31CF965AD"
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
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace EduBanking.Silverlight.Views.Common {
    
    
    public partial class SBBranch : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid front;
        
        internal System.Windows.Controls.StackPanel splHeader;
        
        internal DataGrid dgdCustomer;
        
        internal System.Windows.Controls.Grid back;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AssetManagement;component/Views/Common/SBBranch.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.front = ((System.Windows.Controls.Grid)(this.FindName("front")));
            this.splHeader = ((System.Windows.Controls.StackPanel)(this.FindName("splHeader")));
            this.dgdCustomer = ((DataGrid)(this.FindName("dgdCustomer")));
            this.back = ((System.Windows.Controls.Grid)(this.FindName("back")));
        }
    }
}

