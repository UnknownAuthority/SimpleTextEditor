using System.Text;
using System.IO;
using ReactiveUI;

namespace SimpleTextEditor.ViewModels
{
    public class TextEditViewModel : ViewModelBase
    {

        private string Path = SimpleTextEditor.ViewModels.FilePathViewModel.Path;

        private string Check()
        {
            if (Path == null || Path.Length < 1 || !Directory.Exists(Path))
            {
                Text = "You haven't given a  valid filename/directory so we have defaulted to Doc.txt";
                return "Doc.txt";
            }
            return Path;
        }
        private string? text;
        public string? Text
        {
            get => text;
            //  Again using RaiseAndSetIfChanged because Avalonia depends on change notifs to update gui
            set => this.RaiseAndSetIfChanged(ref text, value);

        }

        public void Save() => File.WriteAllTextAsync(Check(), Text);
        public void Load()
        {
            Path = Check();
            if (!File.Exists(Path))
            {
                FileStream fileStream = File.Create(Path);
                fileStream.DisposeAsync();
                Text = "";
                return;
            }
            Text = File.ReadAllTextAsync(Path, Encoding.UTF8).Result;


        }
    }
}