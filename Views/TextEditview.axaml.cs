//using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SimpleTextEditor.Views
{
    public partial class TexteditView : UserControl
    {
        public TexteditView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}