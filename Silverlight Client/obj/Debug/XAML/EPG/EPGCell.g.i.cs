﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\EPG\EPGCell.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D911017F24699A6C896A5FCF5760B604"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
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


namespace SilverPotato {
    
    
    public partial class EPGCell : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Border brdMainBorder;
        
        internal System.Windows.Media.GradientStop gsCellFadeColour;
        
        internal System.Windows.Media.GradientStop gsCellColour;
        
        internal System.Windows.Controls.Grid gdInnerContent;
        
        internal System.Windows.Controls.ColumnDefinition colRightIcons;
        
        internal System.Windows.Controls.StackPanel spLabels;
        
        internal System.Windows.Controls.TextBlock lblTitle;
        
        internal System.Windows.Controls.TextBlock lblEpisodeTitle;
        
        internal System.Windows.Controls.TextBlock lblTimes;
        
        internal System.Windows.Controls.StackPanel spIcons;
        
        internal System.Windows.Controls.Image imgTop;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/EPG/EPGCell.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.brdMainBorder = ((System.Windows.Controls.Border)(this.FindName("brdMainBorder")));
            this.gsCellFadeColour = ((System.Windows.Media.GradientStop)(this.FindName("gsCellFadeColour")));
            this.gsCellColour = ((System.Windows.Media.GradientStop)(this.FindName("gsCellColour")));
            this.gdInnerContent = ((System.Windows.Controls.Grid)(this.FindName("gdInnerContent")));
            this.colRightIcons = ((System.Windows.Controls.ColumnDefinition)(this.FindName("colRightIcons")));
            this.spLabels = ((System.Windows.Controls.StackPanel)(this.FindName("spLabels")));
            this.lblTitle = ((System.Windows.Controls.TextBlock)(this.FindName("lblTitle")));
            this.lblEpisodeTitle = ((System.Windows.Controls.TextBlock)(this.FindName("lblEpisodeTitle")));
            this.lblTimes = ((System.Windows.Controls.TextBlock)(this.FindName("lblTimes")));
            this.spIcons = ((System.Windows.Controls.StackPanel)(this.FindName("spIcons")));
            this.imgTop = ((System.Windows.Controls.Image)(this.FindName("imgTop")));
        }
    }
}
