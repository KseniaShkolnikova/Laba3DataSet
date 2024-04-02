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
using Entity.PRAKT3DataSetTableAdapters;

namespace Entity
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SUSHI_STORETableAdapter sUSHI = new SUSHI_STORETableAdapter();    
        public MainWindow()
        {
            InitializeComponent();

            ingr.ItemsSource = sUSHI.GetDataBy();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ingr.Columns[0].Visibility=Visibility.Collapsed;
            ingr.Columns[3].Visibility=Visibility.Collapsed;
            ingr.Columns[4].Visibility=Visibility.Collapsed;
        }
    }
}
