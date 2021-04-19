
namespace SimpleTextEditor.ViewModels
{
    public class FilePathViewModel : ViewModelBase
    {
        public static string? path{get; set;}
        public static string Path
        {
            get
            {


                if (path == null || path.Length < 1 || !System.IO.Directory.Exists(path))
                {
                    return "Doc.txt";
                }
                return path;
            }

            set => path = value;
        }
    }    
         

}