using ReactiveUI;
/*using System.Collections.Generic;
using System.Text;
using System.IO;*/


namespace SimpleTextEditor.ViewModels
{
    
    public class MainWindowViewModel : ViewModelBase
    {
        public ViewModelBase? content;
        public MainWindowViewModel(){
            //  We are setting the Content to a new instance to the TexteditViewModel
            Content =  new TextEditViewModel();

        }
        public ViewModelBase? Content{
            
            get => content;
            //  using RaiseAndSetIfChanged because avalonaia uses change notifs to Update the gui
            //  this will be useful later when we will be able to switch between multiple windows 
            set => this.RaiseAndSetIfChanged(ref content, value);
        }
        public void FilePath()
        {
            Content = new FilePathViewModel();
        }  
        public void TextEdit() => Content = new TextEditViewModel(); 
        
        
        
    }   
}
