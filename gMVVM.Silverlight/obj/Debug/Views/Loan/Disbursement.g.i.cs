﻿#pragma checksum "E:\GSOFT\Projects\Asset Management\WIP\Program\mvvmSilverlight\SilverlightProject1\Views\Loan\Disbursement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD1793A6BE22A27858FDF0423263B64A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EduBanking.Silverlight;
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


namespace EduBanking.Silverlight.Views.Loan {
    
    
    public partial class Disbursement : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal EduBanking.Silverlight.ChangeText Format_Price;
        
        internal System.Windows.Controls.StackPanel splHeader;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AssetManagement;component/Views/Loan/Disbursement.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Format_Price = ((EduBanking.Silverlight.ChangeText)(this.FindName("Format_Price")));
            this.splHeader = ((System.Windows.Controls.StackPanel)(this.FindName("splHeader")));
        }
    }
}

