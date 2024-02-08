using InterfacesCRUD.DB;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace InterfacesCRUD
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool isDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

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

        private void exitApp(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }


        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void logIn(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (txt_Username.Text == "" || txt_Password.Password == "")
            {
                txt_Response.Text = "Por favor, rellene todos los campos";
                txt_Response.Visibility = Visibility.Visible;


            }
            else if (Db.login(txt_Username.Text, txt_Password.Password))
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                txt_Response.Text = "Credenciales Incorrectas. Intentelo de Nuevo.";
                txt_Response.Visibility = Visibility.Visible;
            }
        }
    }
}
