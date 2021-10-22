using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Telefonos : Form
    {
        DataSet dsInterno;
        public Telefonos(DataSet dsDatos)
        {
            InitializeComponent();
            dsInterno = dsDatos;

        }

        private void Telefonos_Load(object sender, EventArgs e)
        {
            DataTable tabla = dsInterno.Tables[0];

            foreach(DataRow fila in tabla.Rows)
            {
                foreach(DataColumn columna in tabla.Columns)
                {
                    if (columna.ColumnName.Equals("nombre_apellidos"))
                    {
                        rtbContenido.Text += fila[columna] + " -> ";
                    }else if (columna.ColumnName.Equals("tcontacto"))
                    {
                        rtbContenido.Text += fila[columna] + Environment.NewLine;
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
