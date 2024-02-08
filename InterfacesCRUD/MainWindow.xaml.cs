using InterfacesCRUD.DB;
using MaterialDesignThemes.Wpf;
using MySql.Data.MySqlClient;
using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if (isDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                isDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                isDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void logOut(object sender, EventArgs e)
        {
            if (Db.conexion != null && Db.conexion.State == ConnectionState.Open)
            {
                Db.conexion.Close();
            }

            Login login = new Login();
            login.Show();
            this.Close();

        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {

            Page1 page1 = new Page1();
            frame.Content = page1;
        }

        private void btn_Crud_Click(object sender, RoutedEventArgs e)
        {

            Page2 page2 = new Page2();
            frame.Content = page2;
        }

        private void btn_Prefab_Click(object sender, RoutedEventArgs e)
        {

            Page3 page3 = new Page3();
            frame.Content = page3;

        }
    }
}
