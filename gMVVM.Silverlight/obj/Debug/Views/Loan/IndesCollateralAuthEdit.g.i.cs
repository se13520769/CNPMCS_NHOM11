﻿#pragma checksum "E:\GSOFT\Projects\Asset Management\WIP\Program\mvvmSilverlight\SilverlightProject1\Views\Loan\IndesCollateralAuthEdit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAA40914B0B74796C0A1F5890A3F407B"
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


namespace EduBanking.Silverlight.Views.Loan {
    
    
    public partial class IndesCollateralAuthEdit : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.Animation.Storyboard SwivelToBackStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard SwivelToFrontStoryboard;
        
        internal System.Windows.Controls.StackPanel splHeader;
        
        internal System.Windows.Controls.Border SwivelPanelFront;
        
        internal System.Windows.Controls.Grid grdItems;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.Border SwivelPanelBack;
        
        internal DataGrid dgdCurrency;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AssetManagement;component/Views/Loan/IndesCollateralAuthEdit.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.SwivelToBackStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SwivelToBackStoryboard")));
            this.SwivelToFrontStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SwivelToFrontStoryboard")));
            this.splHeader = ((System.Windows.Controls.StackPanel)(this.FindName("splHeader")));
            this.SwivelPanelFront = ((System.Windows.Controls.Border)(this.FindName("SwivelPanelFront")));
            this.grdItems = ((System.Windows.Controls.Grid)(this.FindName("grdItems")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.SwivelPanelBack = ((System.Windows.Controls.Border)(this.FindName("SwivelPanelBack")));
            this.dgdCurrency = ((DataGrid)(this.FindName("dgdCurrency")));
        }
    }
}

