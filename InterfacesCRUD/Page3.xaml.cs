using InterfacesCRUD.DB;
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

namespace InterfacesCRUD
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        public void btn_MostSold_Click(object sender, RoutedEventArgs e)
        {
            Db.selectMostSold(dataGrid3);
        }

        public void btn_NoStock_Click(object sender, RoutedEventArgs e)
        {
            Db.selectNoStock(dataGrid3);
        }

        public void btn_MostExpensive_Click(object sender, RoutedEventArgs e)
        {
            Db.selectMostExpensive(dataGrid3);
        }
    }
}
