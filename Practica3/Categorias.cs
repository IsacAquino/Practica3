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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Categorias: Form
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IValidator<Categories> _categoriesValidator;
        public Categorias(NorthwindContext northwindContext, IValidator<Categories> categoriesValidator)
        {
            InitializeComponent();
            CategoriesDataGridView.SelectionChanged += CategoryDataGridView_SelectionChanged;
            CategoriesDataGridView.AutoGenerateColumns = false;
            this._northwindContext = northwindContext;
            this._categoriesValidator = categoriesValidator;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            CategoriesDataGridView.DataSource = _northwindContext.Categories.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var category = new Categories();
            //category.CategoryName = categoryNameTextBox.Text;
            //category.Description = descriptionTextBox.Text;

            //var validationResult = _categoriesValidator
            //        .Validate(category);

            //try
            //{
            //    if (validationResult.IsValid)
            //    {
            //        _northwindContext.Categories.Add(category);
            //        _northwindContext.SaveChanges();
            //        MessageBox.Show("Categoria insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadCategories();

            //    }
            //    else
            //    {
            //        try
            //        {
            //            throw new ApplicationException("Some Error");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Lo sentimos. Ocurrio un error inesperado. Intente mas tarde");
            //            Log.Error(ex, ex.Message);
            //        }
            //        var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
            //        MessageBox.Show(validationMessages, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }

            //    categoryNameTextBox.Clear();
            //    descriptionTextBox.Clear();
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error saving categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                var categoryName = categoryNameTextBox.Text;
                var description = descriptionTextBox.Text;

                // Verificar si la categoría ya existe en la base de datos
                var existingCategory = _northwindContext.Categories.FirstOrDefault(c => c.CategoryName == categoryName);

                if (existingCategory != null)
                {
                    MessageBox.Show("La categoría ya está registrada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin insertar la categoría nuevamente
                }

                // Si la categoría no existe, proceder con la inserción
                var category = new Categories
                {
                    CategoryName = categoryName,
                    Description = description
                };

                var validationResult = _categoriesValidator.Validate(category);

                if (validationResult.IsValid)
                {
                    _northwindContext.Categories.Add(category);
                    _northwindContext.SaveChanges();
                    MessageBox.Show("Categoría insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                }
                else
                {
                    try
                    {
                        throw new ApplicationException("Some Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lo sentimos. Ocurrió un error inesperado. Intente más tarde.");
                        Log.Error(ex, ex.Message);
                    }
                    var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                    MessageBox.Show(validationMessages, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                categoryNameTextBox.Clear();
                descriptionTextBox.Clear();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al guardar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriesDataGridView.SelectedRows.Count > 0)
                {
                    // Obtener el nombre de la categoría de la fila seleccionada
                    int categoryId = Convert.ToInt32(CategoriesDataGridView.SelectedRows[0].Cells["CategoryIdColumn1"].Value);

                    // Buscar la categoría por su nombre
                    var categoryToUpdate = _northwindContext.Categories.Find(categoryId);
                    if (categoryToUpdate != null)
                    {
                        // Actualizar las propiedades de la categoría
                        categoryToUpdate.CategoryName = categoryNameTextBox.Text;
                        categoryToUpdate.Description = descriptionTextBox.Text;

                        // Guardar los cambios en la base de datos
                        var validationResult = _categoriesValidator.Validate(categoryToUpdate);

                        if (validationResult.IsValid)
                        {
                            _northwindContext.Categories.Add(categoryToUpdate);
                            _northwindContext.SaveChanges();
                            MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCategories();
                        }

                        else
                        {
                            try
                            {
                                throw new ApplicationException("Some Error");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lo sentimos. Ocurrió un error inesperado. Intente más tarde.");
                                Log.Error(ex, ex.Message);
                            }
                            var validationMessages = string.Join("\n", validationResult.Errors.Select(a => a.ErrorMessage));
                            MessageBox.Show(validationMessages, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Categoría no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al actualizar la categoría: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CategoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoriesDataGridView.SelectedRows.Count > 0)
            {
                var Category = (Categories)CategoriesDataGridView.SelectedRows[0].DataBoundItem;
                categoryNameTextBox.Text = Category.CategoryName;
                descriptionTextBox.Text = Category.Description;

                try
                {
                    if (Category.Picture != null)
                    {
                        var ms = new MemoryStream(Category.Picture, 78, Category.Picture.Length - 78);
                        var bm = new Bitmap(ms);
                        picturePictureBox.Image = bm;
                    }
                    else
                    {
                        picturePictureBox.Image = null;
                        picturePictureBox.InitialImage = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            categoryNameTextBox.Clear();
            descriptionTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    CategoriesDataGridView.DataSource = context.Categories.ToList();
                }

                CategoriesDataGridView.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                if (CategoriesDataGridView.SelectedRows.Count > 0)
                {
                    int categoryId = Convert.ToInt32(CategoriesDataGridView.SelectedRows[0].Cells["CategoryIdColumn1"].Value);
                    var categoryToDelete = _northwindContext.Categories.Find(categoryId);
                    if (categoryToDelete != null)
                    {
                        
                        bool hasReferences = _northwindContext.Products.Any(od => od.CategoryId == categoryId);

                        if (!hasReferences)
                        {
                            _northwindContext.Categories.Remove(categoryToDelete);
                            _northwindContext.SaveChanges();

                            
                            LoadCategories();

                            MessageBox.Show("Categoria eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Esta categoria tiene referencias en otras tablas y no puede ser eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Categoria no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error al eliminar la categoria: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadCategories();
            }

        }

        private void categoryNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
