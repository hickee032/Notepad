using NotePad.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotePad
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainTabItem mti { get; set; }

        public MainWindow() {
            InitializeComponent();
            mti = new MainTabItem();
        }

        public void RefreshLists() {
            
            this.DataContext = null;
            this.DataContext = mti;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {



        }
    }
}
