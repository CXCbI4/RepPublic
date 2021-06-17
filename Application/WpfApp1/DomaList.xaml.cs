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
    /// Логика взаимодействия для DomaList.xaml
    /// </summary>
    public partial class DomaList : Page
    {
        public DomaList()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                domDG.ItemsSource = Database1Entities.GetContext().House.ToList();
                Database1Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new DomaAdd(null));
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new DomaAdd((sender as Button).DataContext as House));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var HouseRemoving = domDG.SelectedItems.Cast<House>().ToList();
            Database1Entities.GetContext().House.RemoveRange(HouseRemoving);
            Database1Entities.GetContext().SaveChanges();
        }
    }
}
