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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class OrdenesDetalles : Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<OrderDetails> _orderDetailsValidator;
        public OrdenesDetalles(NorthwindContext northwindContext, IValidator<OrderDetails> orderDetailsValidator)
        {
            InitializeComponent();
            orderDetailsDataGridView.AutoGenerateColumns = false;
            this._northwindContext = northwindContext;
            this._orderDetailsValidator = orderDetailsValidator;
        }



        private void OrdenesDetalles_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            orderDetailsDataGridView.DataSource = _northwindContext.OrderDetails.ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var orderDetails = new OrderDetails();
                int orderId;
                if (int.TryParse(orderIdTextBox.Text, out orderId))
                {
                    // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                    orderDetails.OrderId = orderId;
                }
                int productId;
                if (int.TryParse(productIdTextBox.Text, out productId))
                {
                    // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                    orderDetails.ProductId = productId;
                }
                decimal unitPrice;
                if (decimal.TryParse(unitPriceTextBox.Text, out unitPrice))
                {
                    // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                    orderDetails.UnitPrice = unitPrice;
                }
                Int16 quantity;
                if (Int16.TryParse(quantityTextBox.Text, out quantity))
                {
                    // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                    orderDetails.Quantity = quantity;
                }
                Single discount;
                if (Single.TryParse(discountTextBox.Text, out discount))
                {
                    // La conversión fue exitosa, puedes asignar supplierId a products.SupplierId
                    orderDetails.Discount = discount;
                }
                

                

                var validationResult = _orderDetailsValidator
                    .Validate(orderDetails);

                if (validationResult.IsValid)
                {
                    _northwindContext.OrderDetails.Add(orderDetails);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Suplidor insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrderDetails();

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
    }
}
