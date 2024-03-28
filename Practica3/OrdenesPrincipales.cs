using FluentValidation;
using Practica3.Data;
using Practica3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class OrdenesPrincipales : Form
    {

        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<Orders> _ordersValidator;
        private readonly IValidator<OrderDetails> _ordersDetailsValidator;
        public OrdenesPrincipales(NorthwindContext northwindContext, IValidator<Orders> ordersValidator, IValidator<OrderDetails> ordersDetailsValidator)
        {
            InitializeComponent();
            this._northwindContext = northwindContext;
            ordersDataGridView.AutoGenerateColumns = false;
            this._ordersValidator = ordersValidator;
            this._ordersDetailsValidator = ordersDetailsValidator;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var clientes = _northwindContext.Customers.Select(c => c.CustomerId).ToList();
            customerIdComboBox.DataSource = clientes;

            var producto = _northwindContext.Products.Select(c => c.ProductId).ToList();
            ProductIdcomboBox.DataSource = producto;

            var empleados = _northwindContext.Employees.ToList();
            employeeIdComboBox.DataSource = empleados;
            employeeIdComboBox.DisplayMember = "FullName";
            employeeIdComboBox.ValueMember = "EmployeeId";

            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = _northwindContext.Orders.ToList();

            // Obtener todos los detalles de las órdenes
            var orderDetails = _northwindContext.OrderDetails.ToList();

            // Unir manualmente los detalles de la orden a las órdenes principales
            var combinedData = new List<object>();
            foreach (var order in orders)
            {
                foreach (var detail in orderDetails.Where(d => d.OrderId == order.OrderId))
                {
                    combinedData.Add(new
                    {
                        order.OrderId,
                        order.CustomerId,
                        order.EmployeeId,
                        order.OrderDate,
                        order.RequiredDate,
                        order.ShippedDate,
                        order.ShipVia,
                        order.Freight,
                        order.ShipName,
                        order.ShipAddress,
                        order.ShipCity,
                        order.ShipRegion,
                        order.ShipPostalCode,
                        order.ShipCountry,
                        detail.ProductId,
                        detail.UnitPrice,
                        detail.Quantity,
                        detail.Discount
                    });
                }
            }

            // Asignar los datos combinados al DataGridView
            ordersDataGridView.DataSource = combinedData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Verificar si algún control de entrada está vacío, lo que indica que el usuario está intentando insertar una nueva orden
                if (string.IsNullOrWhiteSpace(customerIdComboBox.Text) ||
                    employeeIdComboBox.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(shipViaTextBox.Text) ||
                    string.IsNullOrWhiteSpace(freightTextBox.Text) ||
                    string.IsNullOrWhiteSpace(shipNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(shipAddressTextBox.Text) ||
                    string.IsNullOrWhiteSpace(shipCityTextBox.Text) ||
                    string.IsNullOrWhiteSpace(shipRegionTextBox.Text) ||
                    string.IsNullOrWhiteSpace(shipPostalCodeTextBox.Text) ||
                    string.IsNullOrWhiteSpace(shipCountryTextBox.Text))
                {
                    // Crear una nueva orden
                    var newOrder = new Orders
                    {
                        CustomerId = customerIdComboBox.Text,
                        // Obtener el ID del empleado seleccionado
                        EmployeeId = Convert.ToInt32(employeeIdComboBox.SelectedValue),
                        OrderDate = orderDateTimePicker1.Value,
                        RequiredDate = requiredDateTimePicker2.Value,
                        ShippedDate = shippedDateTimePicker3.Value,
                        ShipVia = Convert.ToInt32(shipViaTextBox.Text),
                        Freight = Convert.ToDecimal(freightTextBox.Text),
                        ShipName = shipNameTextBox.Text,
                        ShipAddress = shipAddressTextBox.Text,
                        ShipCity = shipCityTextBox.Text,
                        ShipRegion = shipRegionTextBox.Text,
                        ShipPostalCode = shipPostalCodeTextBox.Text,
                        ShipCountry = shipCountryTextBox.Text
                    };

                    // Validar la nueva orden
                    var validationResult = _ordersValidator.Validate(newOrder);

                    if (validationResult.IsValid)
                    {
                        // Agregar la nueva orden al contexto de base de datos
                        _northwindContext.Orders.Add(newOrder);
                        _northwindContext.SaveChanges();

                        // Insertar los detalles de la orden
                        var newOrderDetails = new OrderDetails
                        {
                            OrderId = newOrder.OrderId, // Usar el ID de la orden recién insertada
                            ProductId = Convert.ToInt32(ProductIdcomboBox.SelectedValue),
                            UnitPrice = Convert.ToDecimal(UnitPriceTextBox.Text),
                            Quantity = Convert.ToInt16(QuantityTextBox.Text),
                            Discount = Convert.ToSingle(DiscountTextBox.Text)
                        };

                        // Agregar los detalles de la orden al contexto de base de datos
                        _northwindContext.OrderDetails.Add(newOrderDetails);
                        _northwindContext.SaveChanges();

                        MessageBox.Show("Orden y detalles insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadOrders();
                        ClearOrderFormFields();
                    }
                    else
                    {
                        // Manejar errores de validación
                        var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                        MessageBox.Show(validationMessages, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Limpiar los campos del formulario después de la inserción
                    //ClearOrderFormFields();
                }
                else
                {
                    // Mostrar mensaje de advertencia si se intenta insertar una nueva orden mientras se está editando una existente
                    MessageBox.Show("No se puede insertar una nueva orden mientras se está editando una existente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void ClearOrderFormFields()
        {
            customerIdComboBox.SelectedIndex = -1;
            employeeIdComboBox.SelectedIndex = -1;
            orderDateTimePicker1.Value = DateTime.Today;
            requiredDateTimePicker2.Value = DateTime.Today;
            shippedDateTimePicker3.Value = DateTime.Today;
            shipViaTextBox.Clear();
            freightTextBox.Clear();
            shipNameTextBox.Clear();
            shipAddressTextBox.Clear();
            shipCityTextBox.Clear();
            shipRegionTextBox.Clear();
            shipPostalCodeTextBox.Clear();
            shipCountryTextBox.Clear();
            ProductIdcomboBox.SelectedIndex = -1;
            UnitPriceTextBox.Clear();
            QuantityTextBox.Clear();
            DiscountTextBox.Clear();

            LoadOrders();
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
            customerIdComboBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["CustomerIdColumn1"].Value);
            employeeIdComboBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["EmployeeIdColumn1"].Value);
            orderDateTimePicker1.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["OrderDateColumn1"].Value);
            requiredDateTimePicker2.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["RequiredDateColumn1"].Value);
            shippedDateTimePicker3.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShippedDateColumn1"].Value);
            shipViaTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipViaColumn1"].Value);
            freightTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["FreightColumn1"].Value);
            shipNameTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipNameColumn1"].Value);
            shipAddressTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipAddressColumn1"].Value);
            shipCityTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipCityColumn1"].Value);
            shipRegionTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipRegionColumn1"].Value);
            shipPostalCodeTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipPostalCodeColumn1"].Value);
            shipCountryTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipCountryColumn1"].Value);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            customerIdComboBox.SelectedIndex = -1;
            employeeIdComboBox.SelectedIndex = -1;
            orderDateTimePicker1.Value = DateTime.Today;
            requiredDateTimePicker2.Value = DateTime.Today;
            shippedDateTimePicker3.Value = DateTime.Today;
            shipViaTextBox.Clear();
            freightTextBox.Clear();
            shipNameTextBox.Clear();
            shipAddressTextBox.Clear();
            shipCityTextBox.Clear();
            shipRegionTextBox.Clear();
            shipPostalCodeTextBox.Clear();
            shipCountryTextBox.Clear();

        }

        private void RefreshForm()
        {
            // Limpiar todos los campos de entrada
            customerIdComboBox.SelectedIndex = -1;
            employeeIdComboBox.SelectedIndex = -1;
            orderDateTimePicker1.Value = DateTime.Today;
            requiredDateTimePicker2.Value = DateTime.Today;
            shippedDateTimePicker3.Value = DateTime.Today;
            shipViaTextBox.Clear();
            freightTextBox.Clear();
            shipNameTextBox.Clear();
            shipAddressTextBox.Clear();
            shipCityTextBox.Clear();
            shipRegionTextBox.Clear();
            shipPostalCodeTextBox.Clear();
            shipCountryTextBox.Clear();

            // Recargar la lista de productos en el DataGridView
            LoadOrders();
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

            try
            {
                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la clave primaria de la fila seleccionada
                    int orderId = Convert.ToInt32(ordersDataGridView.SelectedRows[0].Cells["OrderIdColumn1"].Value);

                    // Obtener el pedido a modificar
                    var orderToUpdate = _northwindContext.Orders.Find(orderId);
                    if (orderToUpdate != null)
                    {
                        // Actualizar las propiedades del pedido con los valores de los controles
                        orderToUpdate.CustomerId = customerIdComboBox.Text;

                        // Obtener el ID del empleado seleccionado
                        if (employeeIdComboBox.SelectedItem != null)
                        {
                            orderToUpdate.EmployeeId = Convert.ToInt32(employeeIdComboBox.SelectedValue);
                        }

                        orderToUpdate.OrderDate = orderDateTimePicker1.Value;
                        orderToUpdate.RequiredDate = requiredDateTimePicker2.Value;
                        orderToUpdate.ShippedDate = shippedDateTimePicker3.Value;

                        int shipVia;
                        if (int.TryParse(shipViaTextBox.Text, out shipVia))
                        {
                            orderToUpdate.ShipVia = shipVia;
                        }
                        decimal freight;
                        if (decimal.TryParse(freightTextBox.Text, out freight))
                        {
                            orderToUpdate.Freight = freight;
                        }

                        orderToUpdate.ShipName = shipNameTextBox.Text;
                        orderToUpdate.ShipAddress = shipAddressTextBox.Text;
                        orderToUpdate.ShipCity = shipCityTextBox.Text;
                        orderToUpdate.ShipRegion = shipRegionTextBox.Text;
                        orderToUpdate.ShipPostalCode = shipPostalCodeTextBox.Text;
                        orderToUpdate.ShipCountry = shipCountryTextBox.Text;

                        // Guardar los cambios en la base de datos
                        _northwindContext.SaveChanges();

                        // Recargar los datos en el DataGridView
                        LoadOrders();

                        MessageBox.Show("Pedido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pedido no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al actualizar la orden: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearOrderFormFields(); // Refrescar todo el formulario incluso en caso de error
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {


            try
            {
                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    int orderId = Convert.ToInt32(ordersDataGridView.SelectedRows[0].Cells["OrderIdColumn1"].Value);
                    var orderToDelete = _northwindContext.Orders.Find(orderId);
                    if (orderToDelete != null)
                    {
                        // Verificar si el producto tiene referencias en otras tablas
                        bool hasReferences = _northwindContext.OrderDetails.Any(od => od.OrderId == orderId);

                        if (!hasReferences)
                        {
                            _northwindContext.Orders.Remove(orderToDelete);
                            _northwindContext.SaveChanges();

                            // Refrescar todo el formulario
                            ClearOrderFormFields();

                            MessageBox.Show("Orden eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else
                        {
                            MessageBox.Show("Esta orden tiene referencias en otras tablas y no puede ser eliminada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Orden no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una orden para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al eliminar la orden: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearOrderFormFields(); // Refrescar todo el formulario incluso en caso de error
            }

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

        private void customerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ordersDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            customerIdComboBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["CustomerIdColumn1"].Value);
            employeeIdComboBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["EmployeeIdColumn1"].Value);
            orderDateTimePicker1.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["OrderDateColumn1"].Value);
            requiredDateTimePicker2.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["RequiredDateColumn1"].Value);
            shippedDateTimePicker3.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShippedDateColumn1"].Value);
            shipViaTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipViaColumn1"].Value);
            freightTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["FreightColumn1"].Value);
            shipNameTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipNameColumn1"].Value);
            shipAddressTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipAddressColumn1"].Value);
            shipCityTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipCityColumn1"].Value);
            shipRegionTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipRegionColumn1"].Value);
            shipPostalCodeTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipPostalCodeColumn1"].Value);
            shipCountryTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipCountryColumn1"].Value);
            ProductIdcomboBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ProductIdColumn1"].Value);
            UnitPriceTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["UnitPriceColumn1"].Value);
            QuantityTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["QuantityColumn1"].Value);
            DiscountTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["DiscountColumn1"].Value);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            customerIdComboBox.SelectedIndex = -1;
            employeeIdComboBox.SelectedIndex = -1;
            orderDateTimePicker1.Value = DateTime.Today;
            requiredDateTimePicker2.Value = DateTime.Today;
            shippedDateTimePicker3.Value = DateTime.Today;
            shipViaTextBox.Clear();
            freightTextBox.Clear();
            shipNameTextBox.Clear();
            shipAddressTextBox.Clear();
            shipCityTextBox.Clear();
            shipRegionTextBox.Clear();
            shipPostalCodeTextBox.Clear();
            shipCountryTextBox.Clear();
            ProductIdcomboBox.SelectedIndex = -1;
            UnitPriceTextBox.Clear();
            QuantityTextBox.Clear();
            DiscountTextBox.Clear();

            LoadOrders();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                var combinedData = (from order in _northwindContext.Orders
                                    join detail in _northwindContext.OrderDetails on order.OrderId equals detail.OrderId
                                    select new
                                    {
                                        order.OrderId,
                                        order.CustomerId,
                                        order.EmployeeId,
                                        order.OrderDate,
                                        order.RequiredDate,
                                        order.ShippedDate,
                                        order.ShipVia,
                                        order.Freight,
                                        order.ShipName,
                                        order.ShipAddress,
                                        order.ShipCity,
                                        order.ShipRegion,
                                        order.ShipPostalCode,
                                        order.ShipCountry,
                                        detail.ProductId,
                                        detail.UnitPrice,
                                        detail.Quantity,
                                        detail.Discount
                                    }).ToList();

                ordersDataGridView.DataSource = combinedData;
                ordersDataGridView.Visible = true; // Establecer como visible después de cargar los datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    int orderId = Convert.ToInt32(ordersDataGridView.SelectedRows[0].Cells["OrderIdColumn1"].Value);

                    // Buscar y eliminar los detalles de la orden asociados a la orden seleccionada
                    var orderDetailsToDelete = _northwindContext.OrderDetails.Where(od => od.OrderId == orderId).ToList();
                    _northwindContext.OrderDetails.RemoveRange(orderDetailsToDelete);

                    // Eliminar la orden principal
                    var orderToDelete = _northwindContext.Orders.Find(orderId);
                    if (orderToDelete != null)
                    {
                        _northwindContext.Orders.Remove(orderToDelete);
                        _northwindContext.SaveChanges();

                        // Refrescar todo el formulario
                        ClearOrderFormFields();

                        MessageBox.Show("Orden y detalles eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Orden no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una orden para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al eliminar la orden: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearOrderFormFields(); // Refrescar todo el formulario incluso en caso de error
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {   
            try
            {
                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la clave primaria de la fila seleccionada
                    int orderId = Convert.ToInt32(ordersDataGridView.SelectedRows[0].Cells["OrderIdColumn1"].Value);

                    // Obtener la orden principal a modificar
                    var orderToUpdate = _northwindContext.Orders.Find(orderId);
                    if (orderToUpdate != null)
                    {
                        // Actualizar las propiedades de la orden principal con los valores de los controles
                        orderToUpdate.CustomerId = customerIdComboBox.Text;

                        // Obtener el ID del empleado seleccionado
                        if (employeeIdComboBox.SelectedItem != null)
                        {
                            orderToUpdate.EmployeeId = Convert.ToInt32(employeeIdComboBox.SelectedValue);
                        }

                        orderToUpdate.OrderDate = orderDateTimePicker1.Value;
                        orderToUpdate.RequiredDate = requiredDateTimePicker2.Value;
                        orderToUpdate.ShippedDate = shippedDateTimePicker3.Value;

                        int shipVia;
                        if (int.TryParse(shipViaTextBox.Text, out shipVia))
                        {
                            orderToUpdate.ShipVia = shipVia;
                        }
                        decimal freight;
                        if (decimal.TryParse(freightTextBox.Text, out freight))
                        {
                            orderToUpdate.Freight = freight;
                        }

                        orderToUpdate.ShipName = shipNameTextBox.Text;
                        orderToUpdate.ShipAddress = shipAddressTextBox.Text;
                        orderToUpdate.ShipCity = shipCityTextBox.Text;
                        orderToUpdate.ShipRegion = shipRegionTextBox.Text;
                        orderToUpdate.ShipPostalCode = shipPostalCodeTextBox.Text;
                        orderToUpdate.ShipCountry = shipCountryTextBox.Text;

                        // Actualizar los detalles de la orden asociados a la orden principal
                        foreach (var detail in orderToUpdate.OrderDetails)
                        {
                            // Aquí puedes actualizar las propiedades de los detalles de la orden según sea necesario
                            // Por ejemplo:
                             detail.ProductId = Convert.ToInt32(ProductIdcomboBox.SelectedValue);
                             detail.UnitPrice = Convert.ToDecimal(UnitPriceTextBox.Text);
                             detail.Quantity = Convert.ToInt16(QuantityTextBox.Text);
                             detail.Discount = Convert.ToSingle(DiscountTextBox.Text);
                        }

                        // Guardar los cambios en la base de datos
                        _northwindContext.SaveChanges();

                        // Recargar los datos en el DataGridView
                        LoadOrders();

                        MessageBox.Show("Pedido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pedido no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al actualizar la orden: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearOrderFormFields(); // Refrescar todo el formulario incluso en caso de error
            }





        }
    }
}
