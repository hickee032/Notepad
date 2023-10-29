using NotePad.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotePad.ViewModels
{
    public class FileViewModel
    {
        public DocumentModel Document { get; private set; }

        public ICommand NewCommand { get;}
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }

        public FileViewModel(DocumentModel document) {
            Document = document;
        }
        public void NewFile() { 

            Document.FileName = string.Empty;
            Document.FilePath= string.Empty;
            Document.Text = string.Empty;        
        }
        public void SaveFile() {
        
            File.WriteAllText(Document.FilePath, Document.Text);
        }

    }
}
