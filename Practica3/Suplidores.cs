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
    public partial class Suplidores : Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<Suppliers> _suppliersValidator;
        public Suplidores(NorthwindContext northwindContext, IValidator<Suppliers> suppliersValidator)
        {
            InitializeComponent();
            this._northwindContext = northwindContext;
            this._suppliersValidator = suppliersValidator;
            SuppliersDataGridView.AutoGenerateColumns = false;
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            SuppliersDataGridView.DataSource = _northwindContext.Suppliers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                var companyName = companyNameTextBox.Text;

                var existingSupplier = _northwindContext.Suppliers.FirstOrDefault(s => s.CompanyName == companyName);

                if (existingSupplier != null)
                {
                    MessageBox.Show("El suplidor ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var supplier = new Suppliers
                {
                    CompanyName = companyName,
                    ContactName = contactNameTextBox.Text,
                    ContactTitle = contactTitleTextBox.Text,
                    Address = AddressTextBox.Text,
                    City = cityTextBox.Text,
                    Region = regionTextBox.Text,
                    PostalCode = postalCodeTextBox.Text,
                    Country = countryTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Fax = faxTextBox.Text,
                    HomePage = homePageTextBox.Text
                };

                var validationResult = _suppliersValidator.Validate(supplier);

                if (validationResult.IsValid)
                {
                    _northwindContext.Suppliers.Add(supplier);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Suplidor insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                }
                else
                {
                    var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                    MessageBox.Show(validationMessages, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Limpiar los campos de entrada después de la inserción exitosa
                companyNameTextBox.Clear();
                contactNameTextBox.Clear();
                contactTitleTextBox.Clear();
                AddressTextBox.Clear();
                cityTextBox.Clear();
                regionTextBox.Clear();
                postalCodeTextBox.Clear();
                countryTextBox.Clear();
                phoneTextBox.Clear();
                faxTextBox.Clear();
                homePageTextBox.Clear();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar suplidores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            companyNameTextBox.Clear();
            contactTitleTextBox.Clear();
            contactNameTextBox.Clear();
            AddressTextBox.Clear();
            cityTextBox.Clear();
            regionTextBox.Clear();
            postalCodeTextBox.Clear();
            countryTextBox.Clear();
            phoneTextBox.Clear();
            faxTextBox.Clear();
            homePageTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    SuppliersDataGridView.DataSource = context.Suppliers.ToList();
                }

                SuppliersDataGridView.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SuppliersDataGridView.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria de la fila seleccionada
                int supplierId = Convert.ToInt32(SuppliersDataGridView.SelectedRows[0].Cells["SuppliersIdColumn1"].Value);

                // Obtener el producto a modificar
                var supplierToUpdate = _northwindContext.Suppliers.Find(supplierId);
                if (supplierToUpdate != null)
                {
                    

                    supplierToUpdate.CompanyName = companyNameTextBox.Text;
                    supplierToUpdate.ContactName = contactNameTextBox.Text;
                    supplierToUpdate.ContactTitle = contactTitleTextBox.Text;
                    supplierToUpdate.Address = AddressTextBox.Text;
                    supplierToUpdate.City = cityTextBox.Text;
                    supplierToUpdate.Region = regionTextBox.Text;
                    supplierToUpdate.PostalCode = postalCodeTextBox.Text;
                    supplierToUpdate.Country = countryTextBox.Text;
                    supplierToUpdate.Phone = phoneTextBox.Text;
                    supplierToUpdate.Fax = faxTextBox.Text;
                    supplierToUpdate.HomePage = homePageTextBox.Text;

                    // Guardar los cambios en la base de datos
                    var validationResult = _suppliersValidator.Validate(supplierToUpdate);

                    if (validationResult.IsValid)
                    {
                        _northwindContext.Suppliers.Add(supplierToUpdate);
                        _northwindContext.SaveChanges();
                        LoadSuppliers();
                        MessageBox.Show("Suplidor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                        MessageBox.Show(validationMessages, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Suplidor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un suplidor para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SuppliersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            companyNameTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["CompanyNameColumn1"].Value);
            contactNameTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["ContactNameColumn1"].Value);
            contactTitleTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["ContactTitleColumn1"].Value);
            AddressTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["AddressColumn1"].Value);
            cityTextBox.Text= Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["CityColumn1"].Value);
            regionTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["RegionColumn1"].Value);
            postalCodeTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["PostalCodeColumn1"].Value);
            countryTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["CountryColumn1"].Value);
            phoneTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["PhoneColumn1"].Value);
            faxTextBox.Text= Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["FaxColumn1"].Value);
            homePageTextBox.Text = Convert.ToString(SuppliersDataGridView.CurrentRow.Cells["HomePageColumn1"].Value);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuppliersDataGridView.SelectedRows.Count > 0)
                {
                    int supplierId = Convert.ToInt32(SuppliersDataGridView.SelectedRows[0].Cells["SuppliersIdColumn1"].Value);
                    var supplierToDelete = _northwindContext.Suppliers.Find(supplierId);
                    if (supplierToDelete != null)
                    {
                        // Verificar si el producto tiene referencias en otras tablas
                        bool hasReferences = _northwindContext.Products.Any(od => od.SupplierId== supplierId);

                        if (!hasReferences)
                        {
                            _northwindContext.Suppliers.Remove(supplierToDelete);
                            _northwindContext.SaveChanges();

                            // Refrescar todo el formulario
                            LoadSuppliers();

                            MessageBox.Show("Suplidor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Este suplidor tiene referencias en otras tablas y no puede ser eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Suplidor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un suplidor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al eliminar el suplidor: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSuppliers();
            }
        }
    }
}
