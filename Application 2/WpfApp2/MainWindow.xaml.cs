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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new HouseList());
            Class1.MainFrame = MainFrame;
        }

        private void zk_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void doma_btn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new HouseList());
        }
    }
}
