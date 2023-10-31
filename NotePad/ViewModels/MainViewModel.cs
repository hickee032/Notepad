using NotePad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.ViewModels
{
    public class MainViewModel
    {
        private DocumentModel _document;

        public EditorViewModel Editer { get; set; }
        public FileViewModel File { get; set; }
        public HelpViewModel Help { get; set; }

        public MainViewModel() { 

            _document= new DocumentModel();
            Help= new HelpViewModel();
            Editer = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        
        }
    }
}
