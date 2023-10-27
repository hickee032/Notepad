using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Models
{
    public class DocumentModel : ObservableObject
    {
        private string _text;
        public string Text {
            get { return _text; }
            set { OnpropertyChanged(ref _text, value); }
        
        }

        private string _filePath;
        public string FilePath {
            get { return _filePath; }
            set { OnpropertyChanged(ref _filePath, value); }

        }

        private string _fileName;
        public string FileName {
            get { return _fileName; }
            set { OnpropertyChanged(ref _fileName, value); }

        }

        public bool isEmpty {

            get {
                if(string.IsNullOrEmpty(FileName)||
                    string.IsNullOrEmpty(FilePath)) {
                    return true;
                }
                return false;
            }
        }


    }
}
