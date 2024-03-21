using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Practica3.Data;
using Practica3.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Practica3
{
    public partial class Ordenes : Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<Orders>_ordersValidator;
        public Ordenes(NorthwindContext northwindContext, IValidator<Orders> ordersValidator)
        {
            InitializeComponent();
            this._northwindContext = northwindContext;
            this._ordersValidator = ordersValidator;
            ordersDataGridView.AutoGenerateColumns = false;
            customerIdComboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            employeeIdComboBox.SelectedIndexChanged += employeeIdComboBox_SelectedIndexChanged;
            employeeIdComboBox.DrawItem += employeeIdComboBox_DrawItem;



        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            //var empleados = _northwindContext.Employees.ToList();
            //employeeIdComboBox.DataSource = empleados;
            //employeeIdComboBox.DisplayMember = "EmployeeId"; // Mostrar el ID del empleado
            //employeeIdComboBox.ValueMember = "EmployeeId"; // Usar el ID del empleado como valor seleccionado

            //Cargar clientes en el ComboBox
            var clientes = _northwindContext.Customers.Select(c => c.CustomerId).ToList();
            customerIdComboBox1.DataSource = clientes;

            //LoadOrders();

            //var empleados = _northwindContext.Employees.Select(emp => $"{emp.FirstName} {emp.LastName}").ToList();


            //employeeIdComboBox.DataSource = empleados;



            //var clientes = _northwindContext.Customers.Select(c => c.CustomerId).ToList();

            //// Asignar los IDs de clientes al ComboBox
            //customerIdComboBox1.DataSource = clientes;

            //LoadOrders();

            var empleados = _northwindContext.Employees.ToList();
            employeeIdComboBox.DataSource = empleados;
            employeeIdComboBox.DisplayMember = "FullName"; // Suponiendo que "FullName" es la propiedad que combina el nombre y apellido del empleado
            employeeIdComboBox.ValueMember = "EmployeeId";

            LoadOrders();
        }

       

        private void LoadOrders()
        {
            ordersDataGridView.DataSource = _northwindContext.Orders.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var orders = new Orders();

                orders.CustomerId = customerIdComboBox1.Text;

                // Obtener el ID del empleado seleccionado
                if (employeeIdComboBox.SelectedItem != null)
                {
                    orders.EmployeeId = Convert.ToInt32(employeeIdComboBox.SelectedValue);
                }

                orders.OrderDate = orderDateTimePicker1.Value;
                orders.RequiredDate = requiredDateTimePicker2.Value;
                orders.ShippedDate = shippedDateTimePicker3.Value;

                int shipVia;    
                if (int.TryParse(shipViaTextBox.Text, out shipVia))
                {
                    orders.ShipVia = shipVia;
                }
                decimal freight;
                if (decimal.TryParse(freightTextBox.Text, out freight))
                {
                    orders.Freight = freight;
                }

                orders.ShipName = shipNameTextBox.Text;
                orders.ShipAddress = shipAddressTextBox.Text;
                orders.ShipCity = shipCityTextBox.Text;
                orders.ShipRegion = shipRegionTextBox.Text;
                orders.ShipPostalCode = shipPostalCodeTextBox.Text;
                orders.ShipCountry = shipCountryTextBox.Text;

                var validationResult = _ordersValidator
                    .Validate(orders);

                if (validationResult.IsValid)
                {
                    _northwindContext.Orders.Add(orders);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();

                }
                else
                {
                    try
                    {
                        throw new ApplicationException("Some Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos. Ocurrio un error inesperado. Intente mas tarde");
                        Log.Error(ex, ex.Message);
                    }
                    var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                    MessageBox.Show(validationMessages, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            catch (DbUpdateException ex)
            {
                // Capturar la excepción y mostrar más detalles
                MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class OrderViewModel
        {
            // Propiedades de Orders
            public int OrderId { get; set; }
            public string CustomerId { get; set; }
            public int EmployeeId { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime RequiredDate { get; set; }
            public DateTime ShippedDate { get; set; }
            public int ShipVia { get; set; }
            public decimal Freight { get; set; }
            public string ShipName { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
            public string ShipRegion { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipCountry { get; set; }

            // Propiedades de OrderDetails
            public int ProductId { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void ordersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //customerIdComboBox = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["ProductIdColumn"].Value);
            //productNameTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["ProductNameColumn"].Value);
            //supplierIDTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["SupplierIdColumn"].Value);
            //CategoryIdTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["CategoryIdColumn"].Value);
            //quantityTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["QuantityPerUnitColumn"].Value);
            //UnitPricesTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["UnitPriceColumn"].Value);
            //StockTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["UnitsInStockColumn"].Value);
            //OrdenTextBox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["UnitsOnOrderColumn"].Value);
            //levelTextbox.Text = Convert.ToString(ProductsDataGridView.CurrentRow.Cells["ReorderLevelColumn"].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //customerIdTextBox.Clear();
            //employeeIdTextBox.Clear();
            shipViaTextBox.Clear();
            freightTextBox.Clear();
            shipNameTextBox.Clear();
            shipAddressTextBox.Clear();
            shipCityTextBox.Clear();
            shipRegionTextBox.Clear();
            shipPostalCodeTextBox.Clear();
            shipCountryTextBox.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    ordersDataGridView.DataSource = context.Orders.ToList();
                }

                ordersDataGridView.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria de la fila seleccionada
                string customerId = Convert.ToString(ordersDataGridView.SelectedRows[0].Cells["CustomerIdColumn1"].Value);

                // Obtener el producto a modificar
                var ordersToUpdate = _northwindContext.Orders.Find(customerId);
                if (ordersToUpdate != null)
                {
                    // Actualizar las propiedades del producto con los valores de los TextBox
                    var orders = new Orders();

                    orders.CustomerId = customerIdComboBox1.Text;

                    // Obtener el ID del empleado seleccionado
                    if (employeeIdComboBox.SelectedItem != null)
                    {
                        orders.EmployeeId = Convert.ToInt32(employeeIdComboBox.SelectedValue);
                    }

                    orders.OrderDate = orderDateTimePicker1.Value;
                    orders.RequiredDate = requiredDateTimePicker2.Value;
                    orders.ShippedDate = shippedDateTimePicker3.Value;

                    int shipVia;
                    if (int.TryParse(shipViaTextBox.Text, out shipVia))
                    {
                        orders.ShipVia = shipVia;
                    }
                    decimal freight;
                    if (decimal.TryParse(freightTextBox.Text, out freight))
                    {
                        orders.Freight = freight;
                    }

                    orders.ShipName = shipNameTextBox.Text;
                    orders.ShipAddress = shipAddressTextBox.Text;
                    orders.ShipCity = shipCityTextBox.Text;
                    orders.ShipRegion = shipRegionTextBox.Text;
                    orders.ShipPostalCode = shipPostalCodeTextBox.Text;
                    orders.ShipCountry = shipCountryTextBox.Text;
                    // Guardar los cambios en la base de datos
                    _northwindContext.SaveChanges();
                    LoadOrders();
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeeIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (employeeIdComboBox.SelectedItem != null)
            {
                
                var selectedEmployee = (Employees)employeeIdComboBox.SelectedItem;

                
                int selectedEmployeeId = selectedEmployee.EmployeeId;

            }


        }

        private void employeeIdComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var comboBox = sender as ComboBox;
            if (comboBox == null)
                return;

            var empleado = comboBox.Items[e.Index] as Employees;
            if (empleado == null)
                return;

            // Dibujar el nombre y apellido cuando el elemento está seleccionado
            e.DrawBackground();
            var text = $"{empleado.FirstName} {empleado.LastName}";
            using (var brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }
    }
}
