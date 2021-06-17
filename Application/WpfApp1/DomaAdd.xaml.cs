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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для DomaAdd.xaml
    /// </summary>
    public partial class DomaAdd : Page
    {
        private House _currentHouse = new House();
        public DomaAdd(House house)
        {
            InitializeComponent();

            if (house != null)
                _currentHouse = house;
            DataContext = _currentHouse;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_currentHouse.ID == 0)
                Database1Entities.GetContext().House.Add(_currentHouse);

            try
            {
                Database1Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Class1.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
