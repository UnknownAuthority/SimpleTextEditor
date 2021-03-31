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
            if (Path.Length < 1)
            {
                return "Doc.txt";
            }
            return Path;
        }
        private string? text;
        public string Text
        {
            get => text;
            //  Again using RaiseAndSetIfChanged because Avalonia depends on change notifs to update gui
            set => this.RaiseAndSetIfChanged(ref text, value);

        }

        public void Save()
        {
            File.WriteAllTextAsync(Check(), Text);
        }
        public void Load()
        {
            Path = Check();
            if (File.Exists(Path))
            {

                Text = File.ReadAllTextAsync(Path, Encoding.UTF8).Result;

            }
            else
            {
                File.Create(Path);
            }
        }
    }
}