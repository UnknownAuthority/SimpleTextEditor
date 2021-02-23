using System.Text;
using System.IO;
using ReactiveUI;

namespace SimpleTextEditor.ViewModels
{
    public class TexteditViewModel : ViewModelBase
    {
        public string? text;
        public string? Text
        {
            get => text;
            //Again using RaiseAndSetIfChanged because Avalonia depends on change notifs to update gui
            set => this.RaiseAndSetIfChanged(ref text, value);
        }

        public void Save() => File.WriteAllTextAsync(@"Doc.txt", Text);
        public void Load()
        {

            try
            {
                Text = File.ReadAllTextAsync(@"Doc.txt", Encoding.UTF8).Result;
            }
            catch (System.AggregateException)
            {
                File.Create(@"Doc.txt");

            }





        }
    }
}