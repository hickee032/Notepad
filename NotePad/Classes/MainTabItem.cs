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

        public void AddNewTabItem(string text, string header) {
            TabItem tab = new TabItem();
            TextBox tb = new TextBox();

            ContextMenu cm = new ContextMenu();

            MenuItem mi1 = new MenuItem();
            mi1.Uid = 0.ToString();
            mi1.Header = "Select All Text";
            mi1.Click += TextboxMenuClicks;

            MenuItem mi2 = new MenuItem();
            mi2.Uid = 1.ToString();
            mi2.Header = "Save file";
            mi2.Click += TextboxMenuClicks;

            cm.Items.Add(mi1);
            cm.Items.Add(mi2);

            tb.ContextMenu= cm;
            tb.AutoWordSelection = true;
            tb.Text = "";
            tb.AcceptsReturn= true;
        }

        private void TextboxMenuClicks(object sender, System.Windows.RoutedEventArgs e) {

            switch (int.Parse(((MenuItem)e.Source).Uid)) {
                
                case 0: break;
                case 1: break;

            }
            
        }
    }
}
