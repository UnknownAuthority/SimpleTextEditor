
namespace SimpleTextEditor.ViewModels
{
    public class FilePathViewModel : ViewModelBase
    {
        public static string? _path { get; set; }
        public static string Path
        {
            get
            {
                if (_path == null || _path.Length < 1 || !System.IO.Directory.Exists(_path))
                {
                    return "Doc.txt";
                    
                }
                return _path;
            }

            set => _path = value;
        }
    }


}