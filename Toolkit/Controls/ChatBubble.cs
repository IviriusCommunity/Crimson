using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Crimson.Toolkit.Controls
{
    public sealed class ChatBubble : Control
    {
        public ChatBubble()
        {
            this.DefaultStyleKey = typeof(ChatBubble);
        }

        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
        "Text", // The name of the property
        typeof(string), // The type of the property
        typeof(ChatBubble), // The type of the owner class
        new PropertyMetadata("Text") // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The text in the ChatBubble")]
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }
    }
}
