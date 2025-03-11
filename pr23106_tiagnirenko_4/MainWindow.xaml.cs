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

namespace pr23106_tiagnirenko_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            var searchTitle = searchBox.Text;
            var sortType = sortComboBox.SelectedItem.ToString();

            var groups = Helper.GetGroups(searchTitle, sortType);

            if (groups.Count == 0)
            {
                MessageBox.Show("Результаты поиска отсутствуют.");
            }
            else
            {
                LoadData.ItemsSource = groups;
            }
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoadData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
