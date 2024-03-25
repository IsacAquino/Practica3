﻿using Dapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Practica3.Data;
using Practica3.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private readonly IValidator<OrderDetails> _ordersDetailsValidator;
        public Ordenes(NorthwindContext northwindContext, IValidator<Orders> ordersValidator, IValidator<OrderDetails> ordersDetailsValidator)
        {
            InitializeComponent();
            this._northwindContext = northwindContext;
            this._ordersValidator = ordersValidator;
            this._ordersDetailsValidator = ordersDetailsValidator;
            ordersDataGridView.AutoGenerateColumns = false;
            customerIdComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            employeeIdComboBox.SelectedIndexChanged += employeeIdComboBox_SelectedIndexChanged;
            employeeIdComboBox.DrawItem += employeeIdComboBox_DrawItem;

        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            

            var clientes = _northwindContext.Customers.Select(c => c.CustomerId).ToList();
            customerIdComboBox.DataSource = clientes;

            var empleados = _northwindContext.Employees.ToList();
            employeeIdComboBox.DataSource = empleados;
            employeeIdComboBox.DisplayMember = "FullName";
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

                orders.CustomerId = customerIdComboBox.Text;

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
                    MessageBox.Show("Orden insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                shipViaTextBox.Clear();
                freightTextBox.Clear();
                shipNameTextBox.Clear();
                shipAddressTextBox.Clear();
                shipCityTextBox.Clear();
                shipRegionTextBox.Clear();
                shipPostalCodeTextBox.Clear();
                shipCountryTextBox.Clear();

            }

            catch (DbUpdateException ex)
            {
                // Capturar la excepción y mostrar más detalles
                MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
            freightTextBox.Text= Convert.ToString(ordersDataGridView.CurrentRow.Cells["FreightColumn1"].Value);
            shipNameTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipNameColumn1"].Value);
            shipAddressTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipAddressColumn1"].Value);
            shipCityTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipCityColumn1"].Value);
            shipRegionTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipRegionColumn1"].Value);
            shipPostalCodeTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipPostalCodeColumn1"].Value);
            shipCountryTextBox.Text = Convert.ToString(ordersDataGridView.CurrentRow.Cells["ShipCountryColumn1"].Value);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la clave primaria de la fila seleccionada
                    int orderId= Convert.ToInt32(ordersDataGridView.SelectedRows[0].Cells["OrderIdColumn1"].Value);

                    // Buscar el producto por su clave primaria
                    var orderToDelete = _northwindContext.Orders.Find(orderId);
                    if (orderToDelete != null)
                    {
                        _northwindContext.Orders.Remove(orderToDelete);
                        _northwindContext.SaveChanges();
                        LoadOrders();
                        MessageBox.Show("Order eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Order no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una orden para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {

                MessageBox.Show("Error al eliminar el producto: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
