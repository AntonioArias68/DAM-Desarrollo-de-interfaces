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

namespace ValidarCampos
{
    public partial class VerDatos : Form
    {
        public VerDatos()
        {
            InitializeComponent();
            try
            {
                StreamReader texto = new StreamReader("RegistrosBancarios.txt");
                textBox1.Text = texto.ReadToEnd();
                texto.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No existe ese fichero, o se ha producido un erro al abrirlo");
            }
            
        }

        private void VerDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
