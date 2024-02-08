using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace InterfacesCRUD.DB
{
    class Db
    {

        public static bool exito = true;

        // definimos conexion
        public static MySqlConnection conexion =
            new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");

        // login
        public static Boolean login(String usuario, String contrasena)
        {
            Boolean existe = false;

            if (usuario == "root" && contrasena == "root")
            {
                existe = true;
                conexion.Open();
            }
            conexion.Close();
            return existe;
        }

        // select * from products 
        public static void selectAllProducts(DataGrid dataGrid)
        {
            try
            {
                conexion.Open();

                string consultaProd = "SELECT * FROM products";

                MySqlCommand cmd = new MySqlCommand(consultaProd, conexion);

                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta y llenar el DataTable con los resultados
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        // Cargar los datos del lector en el DataTable
                        dataTable.Load(lector);
                    }
                }

                // Asignar el DataTable como origen de datos del DataGrid
                dataGrid.ItemsSource = dataTable.DefaultView;
                conexion.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static void selectProductById(DataGrid dataGrid, long Id)
        {
            try
            {
                conexion.Open();

                string consultaProd = "SELECT prod.ProductId, prod.ProductName, prod.SupplierId, cate.CategoryId, Cate.CategoryName, prod.QuantityPerUnit, prod.UnitPrice, prod.UnitsInStock, prod.UnitsOnOrder, prod.ReorderLevel, prod.Discontinued" +
                    " FROM products AS prod JOIN categories AS cate ON prod.CategoryId = cate.CategoryId WHERE ProductId = \"" + Id + "%\";";

                MySqlCommand cmd = new MySqlCommand(consultaProd, conexion);

                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta y llenar el DataTable con los resultados
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        // Cargar los datos del lector en el DataTable
                        dataTable.Load(lector);
                    }
                    else
                    {
                        // No hay resultados, mostrar un mensaje en el DataGrid
                        dataTable.Columns.Add("Message", typeof(string));
                        dataTable.Rows.Add("El producto seleccionado no existe. Por favor elija otro producto.");
                    }
                }

                // Asignar el DataTable como origen de datos del DataGrid
                dataGrid.ItemsSource = dataTable.DefaultView;
                conexion.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static void selectProductByName(DataGrid dataGrid, String name)
        {
            try
            {
                conexion.Open();

                string consultaProd = "SELECT prod.ProductId, prod.ProductName, prod.SupplierId, cate.CategoryId, Cate.CategoryName, prod.QuantityPerUnit, prod.UnitPrice, prod.UnitsInStock, prod.UnitsOnOrder, prod.ReorderLevel, prod.Discontinued" +
                    " FROM products AS prod JOIN categories AS cate ON prod.CategoryId = cate.CategoryId WHERE ProductName LIKE \"" + name + "%\";";

                MySqlCommand cmd = new MySqlCommand(consultaProd, conexion);

                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta y llenar el DataTable con los resultados
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        // Cargar los datos del lector en el DataTable
                        dataTable.Load(lector);
                    }
                    else
                    {
                        // No hay resultados, mostrar un mensaje en el DataGrid
                        dataTable.Columns.Add("Message", typeof(string));
                        dataTable.Rows.Add("El producto seleccionado no existe. Por favor elija otro producto.");
                    }
                }

                // Asignar el DataTable como origen de datos del DataGrid
                dataGrid.ItemsSource = dataTable.DefaultView;
                conexion.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static void selectProductByCategoryName(DataGrid dataGrid, String name)
        {
            try
            {
                conexion.Open();

                string consultaProd = "SELECT prod.ProductId, prod.ProductName, prod.SupplierId, cate.CategoryId, Cate.CategoryName, prod.QuantityPerUnit, prod.UnitPrice, prod.UnitsInStock, prod.UnitsOnOrder, prod.ReorderLevel, prod.Discontinued" +
                    " FROM products AS prod JOIN categories AS cate ON prod.categoryId = cate.categoryId WHERE CategoryName Like \"" + name + "%\";";

                MySqlCommand cmd = new MySqlCommand(consultaProd, conexion);

                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta y llenar el DataTable con los resultados
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        // Cargar los datos del lector en el DataTable
                        dataTable.Load(lector);
                    }
                    else
                    {
                        // No hay resultados, mostrar un mensaje en el DataGrid
                        dataTable.Columns.Add("Message", typeof(string));
                        dataTable.Rows.Add("La categoria seleccionada no existe. Por favor elija una de las siguientes categorias: ");
                        dataTable.Rows.Add("Beverages\r\nCondiments\r\nConfections\r\nDairy Products\r\nGrains/Cereals\r\nMeat/Poultry\r\nProduce\r\nSeafood");
                    }
                }

                // Asignar el DataTable como origen de datos del DataGrid
                dataGrid.ItemsSource = dataTable.DefaultView;
                conexion.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static bool createProduct(long prodId, string Prodname, long suppId, long cateId, string quantity, double price, int stock, int order, int reorder, bool discontinued)
        {
            try
            {
                conexion.Open();

                string createQuery = "INSERT INTO products (ProductId, ProductName, SupplierId, CategoryId, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) Values(@prodId, @Prodname, @suppId, @cateId, @quantity, @price, @stock, @order, @reorder, @discontinued);";

                MySqlCommand cmd = new MySqlCommand(createQuery, conexion);

                cmd.Parameters.AddWithValue("@prodId", prodId);
                cmd.Parameters.AddWithValue("@Prodname", Prodname);
                cmd.Parameters.AddWithValue("@suppId", suppId);
                cmd.Parameters.AddWithValue("@cateId", cateId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@order", order);
                cmd.Parameters.AddWithValue("@reorder", reorder);
                cmd.Parameters.AddWithValue("@discontinued", discontinued);

                cmd.ExecuteNonQuery();

                conexion.Close();

                exito = true;
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("El ProductId ya está en uso por otro producto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                exito = false;
                conexion.Close();
                return false;
            }
        }

        public static bool updateProduct(long prodId, string prodName, long suppId, long cateId, string quantity, double price, int stock, int order, int reorder, bool discontinued)
        {
            try
            {
                conexion.Open();

                string updateQuery = "UPDATE products SET ProductName = @prodName, SupplierId = @suppId, CategoryId = @cateId, QuantityPerUnit = @quantity, UnitPrice = @price, UnitsInStock = @stock, UnitsOnOrder = @order, ReorderLevel = @reorder, Discontinued = @discontinued WHERE ProductId = @prodId;";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conexion);

                cmd.Parameters.AddWithValue("@prodId", prodId);
                cmd.Parameters.AddWithValue("@prodName", prodName);
                cmd.Parameters.AddWithValue("@suppId", suppId);
                cmd.Parameters.AddWithValue("@cateId", cateId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@order", order);
                cmd.Parameters.AddWithValue("@reorder", reorder);
                cmd.Parameters.AddWithValue("@discontinued", discontinued);

                int rowsAffected = cmd.ExecuteNonQuery();

                conexion.Close();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("El ProductId no existe. Por favor elija un producto existente.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                conexion.Close();
                return false;
            }
        }

        public static bool deleteProduct(long prodId)
        {
            try
            {
                conexion.Open();

                string deleteQuery = "DELETE FROM products WHERE ProductId = @Id";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, conexion);

                cmd.Parameters.AddWithValue("@Id", prodId);

                int rowsAffected = cmd.ExecuteNonQuery();

                conexion.Close();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("El producto con el ID especificado no existe.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar borrar el producto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                conexion.Close();
                return false;
            }
        }

        public static void selectMostSold(DataGrid dataGrid)
        {
            try
            {
                conexion.Open();

                string consultaProd = "SELECT p.ProductID ,p.ProductName, p.CategoryID, c.CategoryName, p.UnitPrice, SUM(od.Quantity) AS TotalQuantitySold " +
                    "FROM Products p JOIN OrderDetails od ON p.ProductID = od.ProductID " +
                    "JOIN Categories c ON p.CategoryID = c.CategoryID " +
                    "GROUP BY p.ProductID, p.ProductName, p.CategoryID, c.CategoryName, p.UnitPrice " +
                    "ORDER BY TotalQuantitySold DESC LIMIT 5;";

                MySqlCommand cmd = new MySqlCommand(consultaProd, conexion);

                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta y llenar el DataTable con los resultados
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        // Cargar los datos del lector en el DataTable
                        dataTable.Load(lector);
                    }
                }

                // Asignar el DataTable como origen de datos del DataGrid
                dataGrid.ItemsSource = dataTable.DefaultView;
                conexion.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

            public static void selectNoStock (DataGrid dataGrid)
            {
                try
                {
                    conexion.Open();

                    string consultaProd = "SELECT * FROM Products WHERE UnitsInStock = 0;";

                    MySqlCommand cmd = new MySqlCommand(consultaProd, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Ejecutar la consulta y llenar el DataTable con los resultados
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.HasRows)
                        {
                            // Cargar los datos del lector en el DataTable
                            dataTable.Load(lector);
                        }
                    }

                    // Asignar el DataTable como origen de datos del DataGrid
                    dataGrid.ItemsSource = dataTable.DefaultView;
                    conexion.Close();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }

        public static void selectMostExpensive(DataGrid dataGrid)
        {
            try
            {
                conexion.Open();

                string consultaProd = "SELECT * FROM products ORDER BY UnitPrice DESC LIMIT 5;";

                MySqlCommand cmd = new MySqlCommand(consultaProd, conexion);

                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta y llenar el DataTable con los resultados
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        // Cargar los datos del lector en el DataTable
                        dataTable.Load(lector);
                    }
                }

                // Asignar el DataTable como origen de datos del DataGrid
                dataGrid.ItemsSource = dataTable.DefaultView;
                conexion.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


    }
}
