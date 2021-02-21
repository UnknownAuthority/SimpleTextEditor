using System.Text;
using System.IO;
using ReactiveUI;

namespace SimpleTextEditor.ViewModels{
    public class TexteditViewModel : ViewModelBase{
        public string? text;
        public string? Text{get => text; set => this.RaiseAndSetIfChanged(ref text, value) ;}

        public void Save()
        {
            File.WriteAllTextAsync(@"Doc.txt", Text);
        }
        public void Load()
        {
            Text = File.ReadAllTextAsync(@"Doc.txt", Encoding.UTF8).Result;
            


        }
    }
}