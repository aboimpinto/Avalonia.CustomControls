using Avalonia.Controls;

namespace Avalonia.CustomControls.Controls
{
    public class CustomContentControl : ContentControl
    {
        public static readonly AvaloniaProperty HeaderProperty = 
            AvaloniaProperty.Register<CustomContentControl, string>(nameof(Header));

        public string Header 
        { 
            get => (string)GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }
    }
}
