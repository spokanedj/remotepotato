﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Top Level\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0911257DEAC2DFC601B1333A5F4BBCD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SilverPotato;
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


namespace SilverPotato {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Canvas cvBackground;
        
        internal System.Windows.Controls.Grid gdMainContent;
        
        internal System.Windows.Controls.Grid gdBannerTop;
        
        internal System.Windows.Controls.Border btnTopNavBack;
        
        internal System.Windows.Controls.Border btnTopNavHome;
        
        internal System.Windows.Controls.Image imgTopNavHome;
        
        internal System.Windows.Controls.Grid gdNetActivity;
        
        internal System.Windows.Controls.Border btnToggleFullScreen;
        
        internal System.Windows.Controls.Image imgToggleFullScreen;
        
        internal SilverPotato.StatusBar gdFooter;
        
        internal System.Windows.Controls.Grid gdMainLogo;
        
        internal System.Windows.Media.ScaleTransform stMainLogo;
        
        internal SilverPotato.RPLogo rpLogo;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Top%20Level/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.cvBackground = ((System.Windows.Controls.Canvas)(this.FindName("cvBackground")));
            this.gdMainContent = ((System.Windows.Controls.Grid)(this.FindName("gdMainContent")));
            this.gdBannerTop = ((System.Windows.Controls.Grid)(this.FindName("gdBannerTop")));
            this.btnTopNavBack = ((System.Windows.Controls.Border)(this.FindName("btnTopNavBack")));
            this.btnTopNavHome = ((System.Windows.Controls.Border)(this.FindName("btnTopNavHome")));
            this.imgTopNavHome = ((System.Windows.Controls.Image)(this.FindName("imgTopNavHome")));
            this.gdNetActivity = ((System.Windows.Controls.Grid)(this.FindName("gdNetActivity")));
            this.btnToggleFullScreen = ((System.Windows.Controls.Border)(this.FindName("btnToggleFullScreen")));
            this.imgToggleFullScreen = ((System.Windows.Controls.Image)(this.FindName("imgToggleFullScreen")));
            this.gdFooter = ((SilverPotato.StatusBar)(this.FindName("gdFooter")));
            this.gdMainLogo = ((System.Windows.Controls.Grid)(this.FindName("gdMainLogo")));
            this.stMainLogo = ((System.Windows.Media.ScaleTransform)(this.FindName("stMainLogo")));
            this.rpLogo = ((SilverPotato.RPLogo)(this.FindName("rpLogo")));
        }
    }
}
