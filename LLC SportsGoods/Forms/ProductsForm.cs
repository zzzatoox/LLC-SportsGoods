using LLC_SportsGoods.Classes;
using LLC_SportsGoods.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLC_SportsGoods.Forms
{
    public partial class ProductsForm : Form
    {
        private string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        private int countOfProducts;
        public ProductsForm()
        {
            InitializeComponent();

            if (UserData.roleId == 1)
            {
                btnAddProduct.Visible = true;
                tsmiEditProduct.Visible = true;
                tsmiDeleteProduct.Visible = true;
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSuppliers();
            LoadManufacturers();
            LoadCategories();

            CountProducts();
        }

        private void CountProducts()
        {
            
        }

        private void ApplyFilters()
        {
            string searchText = tbSearch.Text.Trim();

            string selectedSupplier = cbSuppliers.SelectedIndex > 0 ? cbSuppliers.Text : null;
            string selectedManufacturer = cbManufacturers.SelectedIndex > 0 ? cbManufacturers.Text : null;
            string selectedCategory = cbCategories.SelectedIndex > 0 ? cbCategories.Text : null;

            DataTable dataTable = (DataTable)dgvProducts.DataSource;
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = string.Empty;

            // применение фильтров
            if (!string.IsNullOrEmpty(searchText))
            {
                dataView.RowFilter = string.Format("[Наименование товара] LIKE '%{0}%'", searchText);
            }

            if (!string.IsNullOrEmpty(selectedSupplier) && selectedSupplier != "Все поставщики")
            {
                if (dataView.RowFilter.Length > 0)
                {
                    dataView.RowFilter += string.Format(" AND Поставщик = '{0}'", selectedSupplier);
                }
                else
                {
                    dataView.RowFilter += string.Format("Поставщик = '{0}'", selectedSupplier);
                }
            }

            if (!string.IsNullOrEmpty(selectedManufacturer) && selectedManufacturer != "Все производители")
            {
                if (dataView.RowFilter.Length > 0)
                {
                    dataView.RowFilter += string.Format(" AND Производитель = '{0}'", selectedManufacturer);
                }
                else
                {
                    dataView.RowFilter += string.Format("Производитель = '{0}'", selectedManufacturer);
                }
            }

            if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Все категории")
            {
                if (dataView.RowFilter.Length > 0)
                {
                    dataView.RowFilter += string.Format(" AND Категория = '{0}'", selectedCategory);
                }
                else
                {
                    dataView.RowFilter += string.Format("Категория = '{0}'", selectedCategory);
                }
            }

            dgvProducts.Refresh();
            PaintTable();
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
                            
                            DataRow row = dataTable.NewRow();
                            row["Производитель"] = "Все производители";
                            dataTable.Rows.InsertAt(row, 0);

                            cbManufacturers.DataSource = dataTable;

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

                            DataRow row = dataTable.NewRow();
                            row["Поставщик"] = "Все поставщики";
                            dataTable.Rows.InsertAt(row, 0);

                            cbSuppliers.DataSource = dataTable;

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

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM ProductsView", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgvProducts.DataSource = dataTable;

                            dgvProducts.RowHeadersVisible = false;
                        }
                    }
                }

                PaintTable();
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine($"Не удалось получить данные из представления {sqlex.Message}");
                ErrorMessage("Не удалось загрузить данные о товарах.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка {ex.Message}");
                ErrorMessage("Произошла непредвиденная ошибка.");
            }
        }

        private void PaintTable()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (Convert.ToInt32(row.Cells[10].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
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

                            DataRow row = dataTable.NewRow();
                            row["Категория"] = "Все категории";
                            dataTable.Rows.InsertAt(row, 0);

                            cbCategories.DataSource = dataTable;

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

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            cbCategories.SelectedIndex = 0;
            cbManufacturers.SelectedIndex = 0;
            cbSuppliers.SelectedIndex = 0;

            ApplyFilters();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                string title = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                string descripotion = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                string manufacturer = dgvProducts.CurrentRow.Cells[6].Value.ToString();
                string price = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                string quantity = dgvProducts.CurrentRow.Cells[10].Value.ToString();

                tbTitle.Text = title;
                rtbDescription.Text = descripotion;
                tbManufacturer.Text = manufacturer;
                tbPrice.Text = price;
                tbQuantity.Text = quantity;

                // получаю фото товара
                string article = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                string photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\{article}.jpg");

                if (File.Exists(photoPath))
                {
                    pbProductImage.ImageLocation = Path.Combine(projectDirectory, photoPath);
                }
                else
                {
                    try
                    {
                        pbProductImage.ImageLocation = Path.Combine(projectDirectory, $"Resources\\picture.png");
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("Не удалось загрузить фотографию товара.");
                        Console.WriteLine($"Error: {ex}");
                    }
                }
            }
        }

        /// <summary>
        /// Отображаю контекстное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentRow = e.RowIndex;

                if (currentRow >= 0)
                {
                    dgvProducts.Rows[currentRow].Selected = true;

                    Point point = dgvProducts.PointToClient(Cursor.Position);

                    cmsProducts.Show(dgvProducts, point);
                }
            }
        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            dgvProducts.Sort(dgvProducts.Columns["Цена"], ListSortDirection.Ascending);
            PaintTable();
        }

        private void rbDescending_CheckedChanged(object sender, EventArgs e)
        {
            dgvProducts.Sort(dgvProducts.Columns["Цена"], ListSortDirection.Descending);
            PaintTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["LoginForm"];
            form.Show();
            this.Close();
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = Application.OpenForms["LoginForm"];
            form.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cbManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
