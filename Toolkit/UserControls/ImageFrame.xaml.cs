using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System.ComponentModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Crimson.Toolkit.UserControls
{
    public sealed partial class ImageFrame : UserControl
    {
        public ImageFrame()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty SourceProperty =
        DependencyProperty.Register(
        "Source", // The name of the property
        typeof(string), // The type of the property
        typeof(ImageFrame), // The type of the owner class
        new PropertyMetadata(null) // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The source of the content of the ImageFrame")]
        public string Source
        {
            get {
                if (GetValue(SourceProperty).ToString().Contains("ms-appx://")) {
                    return (string)GetValue(SourceProperty);
                } else {
                    return BaseUri + (string)GetValue(SourceProperty);
                }
            }
            set { SetValue(SourceProperty, value); }
        }
    }
}
