using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LLC_SportsGoods.Forms.Admin
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitle.Text.Trim()) ||
                string.IsNullOrEmpty(rtbDescription.Text.Trim()) ||
                string.IsNullOrEmpty(mtbQuantity.Text.Trim()) ||
                string.IsNullOrEmpty(tbPrice.Text.Trim()))
            {
                WarningMessage("Необходимо заполнить все поля");
                return;
            }

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadManufacturers();
            LoadCategories();
        }

        private void LoadManufacturers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM ManufacturersView", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            cbManufacturers.DisplayMember = "Производитель";

                            cbManufacturers.DataSource = dataTable;

                            cbManufacturers.Items.Insert(0, "Все производители");

                            cbManufacturers.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine($"Не удалось получить данные из представления {sqlex.Message}");
                ErrorMessage("Не удалось загрузить данные о производителях.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка {ex.Message}");
                ErrorMessage("Произошла непредвиденная ошибка.");
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM SuppliersView", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            cbSuppliers.DisplayMember = "Поставщик";

                            cbSuppliers.DataSource = dataTable;

                            cbSuppliers.Items.Insert(0, "Все поставщики");

                            cbSuppliers.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine($"Не удалось получить данные из представления {sqlex.Message}");
                ErrorMessage("Не удалось загрузить данные о поставщиках.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка {ex.Message}");
                ErrorMessage("Произошла непредвиденная ошибка.");
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM CategoriesView", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            cbCategories.DisplayMember = "Категория";

                            cbCategories.DataSource = dataTable;

                            cbCategories.Items.Insert(0, "Все категории");

                            cbCategories.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine($"Не удалось получить данные из представления {sqlex.Message}");
                ErrorMessage("Не удалось загрузить данные о категориях.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка {ex.Message}");
                ErrorMessage("Произошла непредвиденная ошибка.");
            }
        }

        private void WarningMessage(string message)
        {
            MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
