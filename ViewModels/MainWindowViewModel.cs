using ReactiveUI;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace SimpleTextEditor.ViewModels
{
    
    public class MainWindowViewModel : ViewModelBase
    {
        

        public void Save()
        {
            File.WriteAllTextAsync(@"Doc.txt", Text);
        }
        public void Load()
        {
            Text = File.ReadAllTextAsync(@"Doc.txt", Encoding.UTF8).Result;
            

        }
        public string? Text{get; set;}
    }
}
