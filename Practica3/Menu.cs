using Microsoft.Extensions.DependencyInjection;
using Practica3.Models;
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
    public partial class Menu : Form
    {
        public readonly Productos _productos;
        public readonly Categorias _categorias;
        public readonly Suplidores _suplidores;
        public readonly OrdenesPrincipales _ordenesPrincipales;
        public Menu(Productos productos, Categorias categorias, Suplidores suplidores, OrdenesPrincipales ordenesPrincipales)
        {
            InitializeComponent();
            _productos = productos;
            _categorias = categorias;
            _suplidores = suplidores;
            
            _ordenesPrincipales = ordenesPrincipales;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            _productos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _categorias.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _suplidores.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            _ordenesPrincipales.ShowDialog(); 
        }
    }
}
