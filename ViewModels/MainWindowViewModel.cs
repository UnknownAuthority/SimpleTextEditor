using ReactiveUI;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace SimpleTextEditor.ViewModels
{
    
    public class MainWindowViewModel : ViewModelBase
    {
        public ViewModelBase? content;
        public MainWindowViewModel(){
            Content =  new TexteditViewModel();

        }
        public ViewModelBase? Content{
            get => content;
            set => this.RaiseAndSetIfChanged(ref content, value);
        }    
        
        
        
    }   
}
