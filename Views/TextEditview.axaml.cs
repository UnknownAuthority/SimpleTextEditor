//using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SimpleTextEditor.Views
{
    public partial class TextEditView : UserControl
    {
        public TextEditView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}