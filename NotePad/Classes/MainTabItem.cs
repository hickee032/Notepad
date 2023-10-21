using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NotePad.Classes
{
    public class MainTabItem : PropertyChangedStuff
    {

        public List<TabItem> Item { get; set; }

        public List<string> FilePaths { get; set; }

        public List<string> FileData { get; set; }

        private int _selectedItem;

        public int SelectedItem {

            get { return _selectedItem; }
            set { _selectedItem = value; RaisePropertyChanged(nameof(SelectedItem)); }
        }

        public MainTabItem() {
            Item = new List<TabItem>();
            FilePaths = new List<string>();
            FileData = new List<string>();
        }

        #region variable
        private string _defaultName = "New Item";
        #endregion

        public void AddNewTabItem() {
            TabItem tab = new TabItem();
            TextBox tb = new TextBox();
        }
    }
}
