using InterfacesCRUD.DB;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterfacesCRUD
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, RoutedEventArgs e)
        {
            String name = txt_Select.Text;

            if (byProdName.IsChecked == true && byCategoryName.IsChecked == false && byProdId.IsChecked == false)
            {
                // Llamar al método selectProductByName con el texto de txt_Select
                Db.selectProductByName(dataGrid2, name);
            }
            else if (byProdName.IsChecked == false && byCategoryName.IsChecked == true && byProdId.IsChecked == false)
            {
                // Llamar al método selectProductByCategoryName con el texto de txt_Select
                Db.selectProductByCategoryName(dataGrid2, name);
            }
            else if (byProdName.IsChecked == false && byCategoryName.IsChecked == false && byProdId.IsChecked == true)
            {
                // Convertir el nombre a un número long
                if (long.TryParse(name, out long prodId))
                {
                    // Llamar al método selectProductById con el número long
                    Db.selectProductById(dataGrid2, prodId);
                }
                else
                {
                    // Mostrar un mensaje de error si el valor no se puede convertir a long
                    MessageBox.Show("El ID de producto debe ser un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                // Si más de un CheckBox está marcado o ninguno está marcado, mostrar un mensaje de error
                MessageBox.Show("Por favor elija solo una opción", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ProdId.Text) || string.IsNullOrWhiteSpace(txt_ProdName.Text) ||
                    string.IsNullOrWhiteSpace(txt_SuppId.Text) || string.IsNullOrWhiteSpace(txt_CateId.Text) ||
                    string.IsNullOrWhiteSpace(txt_Price.Text) || string.IsNullOrWhiteSpace(txt_Stock.Text) ||
                    string.IsNullOrWhiteSpace(txt_Order.Text) || string.IsNullOrWhiteSpace(txt_Reorder.Text) ||
                    string.IsNullOrWhiteSpace(txt_Discontinued.Text))
                {
                    MessageBox.Show("Por favor rellene todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                long prodId, suppId, cateId;
                double price;
                int stock, order, reorder;
                bool discontinued;

                if (!long.TryParse(txt_ProdId.Text, out prodId) ||
                    !long.TryParse(txt_SuppId.Text, out suppId) ||
                    !long.TryParse(txt_CateId.Text, out cateId) ||
                    !double.TryParse(txt_Price.Text, out price) ||
                    !int.TryParse(txt_Stock.Text, out stock) ||
                    !int.TryParse(txt_Order.Text, out order) ||
                    !int.TryParse(txt_Reorder.Text, out reorder) ||
                    !bool.TryParse(txt_Discontinued.Text, out discontinued))
                {
                    MessageBox.Show("Por favor use los valores correspondientes", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (Db.createProduct(prodId, txt_ProdName.Text, suppId, cateId, txt_Quantity.Text, price, stock, order, reorder, discontinued))
                {
                    MessageBox.Show("Producto con Id: " + prodId + " creado correctamente.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar crear el producto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine(ex);
            }
        }

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ProdId.Text) || string.IsNullOrWhiteSpace(txt_ProdName.Text) ||
                    string.IsNullOrWhiteSpace(txt_SuppId.Text) || string.IsNullOrWhiteSpace(txt_CateId.Text) ||
                    string.IsNullOrWhiteSpace(txt_Price.Text) || string.IsNullOrWhiteSpace(txt_Stock.Text) ||
                    string.IsNullOrWhiteSpace(txt_Order.Text) || string.IsNullOrWhiteSpace(txt_Reorder.Text) ||
                    string.IsNullOrWhiteSpace(txt_Discontinued.Text))
                {
                    MessageBox.Show("Por favor rellene todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                long prodId, suppId, cateId;
                double price;
                int stock, order, reorder;
                bool discontinued;

                if (!long.TryParse(txt_ProdId.Text, out prodId) ||
                    !long.TryParse(txt_SuppId.Text, out suppId) ||
                    !long.TryParse(txt_CateId.Text, out cateId) ||
                    !double.TryParse(txt_Price.Text, out price) ||
                    !int.TryParse(txt_Stock.Text, out stock) ||
                    !int.TryParse(txt_Order.Text, out order) ||
                    !int.TryParse(txt_Reorder.Text, out reorder) ||
                    !bool.TryParse(txt_Discontinued.Text, out discontinued))
                {
                    MessageBox.Show("Por favor use los valores correspondientes", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (Db.updateProduct(prodId, txt_ProdName.Text, suppId, cateId, txt_Quantity.Text, price, stock, order, reorder, discontinued))
                {
                    MessageBox.Show("Producto con Id: " + prodId + " editado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar el producto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine(ex);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                long idToDelete;
                if (long.TryParse(txt_toDelete.Text, out idToDelete))
                {
                    if (Db.deleteProduct(idToDelete))
                    {
                        MessageBox.Show("Producto con Id: " + idToDelete + " borrado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca un ID de producto válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar borrar el producto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Debug.WriteLine(ex);
            }
        }
    }
}
