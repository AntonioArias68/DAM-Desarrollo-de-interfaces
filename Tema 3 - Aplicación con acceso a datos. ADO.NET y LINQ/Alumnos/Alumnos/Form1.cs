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
using System.Xml;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        string ruta;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerXML_Click(object sender, EventArgs e)
        {
            if(abrir.ShowDialog() == DialogResult.OK)
            {
                ruta = abrir.FileName;
                LimpiarDatos();
                dsDatos.ReadXml(ruta);
                dgvDatos.DataSource = dsDatos.Tables[0];
                ActivarOpciones();
            }
        }

        private void ActivarOpciones()
        {
            btnEsquema.Enabled = true;
            btnTeléfonos.Enabled = true;
            btnGuardarXML.Enabled = true;
        }

        private void LimpiarDatos()
        {
            dsDatos = new DataSet();
            dgvDatos.DataSource = null;
            dgvDatos.Rows.Clear();
            dgvDatos.Refresh();
            rtbEsquema.Text = "";
        }

        private void btnEsquema_Click(object sender, EventArgs e)
        {
            StringWriter swXML = new StringWriter();
            this.dsDatos.WriteXmlSchema(swXML);
            this.rtbEsquema.Text = swXML.ToString();
        }

        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            FileStream fichXML = new FileStream(ruta, FileMode.Create);
            this.dsDatos.WriteXml(fichXML);
            fichXML.Close();
            MessageBox.Show("Guardado");
        }

        private void btnTeléfonos_Click(object sender, EventArgs e)
        {
            Telefonos frm = new Telefonos(dsDatos);
            frm.ShowDialog();
        }

        private void btnFichero_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement elementoRaiz = xDoc.CreateElement(string.Empty, "raiz", string.Empty);
            xDoc.AppendChild(elementoRaiz);

            XmlElement xHijo = xDoc.CreateElement(string.Empty, "hijo", string.Empty);

            xHijo.SetAttribute("id", "el_valor_que_yo_quiera");

            XmlElement xUna = xDoc.CreateElement(string.Empty, "una", string.Empty);
            XmlElement xOtra = xDoc.CreateElement(string.Empty, "otra", string.Empty);

            XmlText xTxTUna = xDoc.CreateTextNode("Un_valor");
            xUna.AppendChild(xTxTUna);
            XmlText xTxTOtra = xDoc.CreateTextNode("Otro_valor");
            xOtra.AppendChild(xTxTOtra);

            xHijo.AppendChild(xUna);
            xHijo.AppendChild(xOtra);

            elementoRaiz.AppendChild(xHijo);

            XmlTextWriter xtw = new XmlTextWriter("prueba.xml", Encoding.UTF8);
            xtw.Formatting = Formatting.Indented;
            xDoc.Save(xtw);
            xtw.Close();
        }
    }
}
