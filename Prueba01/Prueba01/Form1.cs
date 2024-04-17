using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cerrar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<string> lista=new List<string>();
        private void Aceptar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txt_nombre.Text;
            lista.Add(nombre);
            txtNombres.DataSource = null;
            txtNombres.DataSource = lista;

        }

        
    }

    
}
