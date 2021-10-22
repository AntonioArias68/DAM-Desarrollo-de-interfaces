using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Horarios
{
    public partial class Form1 : Form
    {

        Utilidades ut = new Utilidades();
        ListBox[] listaLB;
        Label[] listaLblLb, listaLblCb;
        ComboBox[] listaCB;
        string ruta;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ut.cambiarAsig(this.lsbModulo, this.lsbCiclo, this.cmbCurso);
        }

        private void lsbCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ut.cambiarAsig(this.lsbModulo, this.lsbCiclo, this.cmbCurso);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listaCB = new ComboBox[] { this.cmbCurso, this.cmbDia, this.cmbHora };
            listaLB = new ListBox[] { this.lsbCiclo, this.lsbModulo };
            listaLblCb = new Label[] { this.lblCurso, this.lblDia, this.lblHora };
            listaLblLb = new Label[] { this.lblCiclo, this.lblModulo };

            bool combo = ut.seleccionadoCB(listaCB, erpErrorCB, listaLblCb);
            bool lista = ut.seleccionadoLB(listaLB, erpErrorLB, listaLblLb);

            if (!combo || !lista)
            {
                MessageBox.Show("Tiene que insertar un valor en los campos obligatorios",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                //Agregamos la asignatura a la celda seleccionada
                ut.addAsignatura(this.dgvHorario, this.cmbCurso, this.lsbModulo, this.lsbCiclo);
                this.lsbCiclo.Enabled = false;
                this.cmbCurso.Enabled = false;
            }
        }

        private void dgvHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDia.SelectedIndexChanged -= cmbDia_SelectedIndexChanged;
            cmbHora.SelectedIndexChanged -= cmbHora_SelectedIndexChanged;
            comprobaSeleccion();
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;
            cmbHora.SelectedIndexChanged += cmbHora_SelectedIndexChanged;
        }

        private void comprobaSeleccion()
        {
            this.cmbHora.SelectedIndex = this.dgvHorario.CurrentRow.Index;
            this.cmbDia.SelectedIndex = this.dgvHorario.CurrentCell.ColumnIndex - 1;
        }

        private void dgvHorario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ut.tablaCompleta(this.dgvHorario, this.btnGuardar);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                limpiarDatos();

                xDoc = new XmlDocument();
                int cont_hora = 0;
                try
                {
                    //Ruta en la que se encuentra el .xml seleccionado
                    ruta = abrir.FileName;
                    xDoc.Load(ruta);

                    //Añadimos la tabla al horario directamente, con las columnas fijas
                    dsDatos.Tables.Add(new DataTable("horario"));
                    dsDatos.Tables[0].Columns.Add("Hora", typeof(string));
                    dsDatos.Tables[0].Columns.Add("Lunes", typeof(string));
                    dsDatos.Tables[0].Columns.Add("Martes", typeof(string));
                    dsDatos.Tables[0].Columns.Add("Miercoles", typeof(string));
                    dsDatos.Tables[0].Columns.Add("Jueves", typeof(string));
                    dsDatos.Tables[0].Columns.Add("Viernes", typeof(string));

                    XmlNodeList horario = xDoc.GetElementsByTagName("horario");
                    XmlNodeList horas = ((XmlElement)horario[0]).GetElementsByTagName("hora");

                    foreach (XmlElement hora in horas)
                    {
                        string[] fila_pant = new string[6];
                        string[] fila_ayu = new string[6];
                        
                        fila_pant[0] = hora.GetAttribute("id").ToString();
                        fila_ayu[0] = "";
                        int col = 1;
                        XmlNodeList dias = hora.GetElementsByTagName("dia");

                        foreach (XmlElement dia in dias)
                        {
                            XmlNodeList entrada_pant = dia.GetElementsByTagName("asignatura");
                            fila_pant[col] = ((XmlElement)entrada_pant[0]).InnerText.ToString();
                            XmlNodeList entrada_ayu = dia.GetElementsByTagName("ayuda");
                            fila_ayu[col] = ((XmlElement)entrada_ayu[0]).InnerText.ToString();
                            col++;
                        }
                        dsDatos.Tables[0].Rows.Add(fila_pant);

                        /*
                         * Antes de pasar a la siguiente fila, se enlaza el dataGridView y el DataSet 
                        */
                        dgvHorario.DataSource = dsDatos.Tables[0];

                        for (int c = 1; c < fila_ayu.Length; c++)
                        {
                            dgvHorario.Rows[cont_hora].Cells[c].ToolTipText = fila_ayu[c];
                        }
                        cont_hora++;
                    }

                }
                catch (XmlException)
                {
                    MessageBox.Show("Intentando cargar un archivo no compatible", "ERROR",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ut.tablaCompleta(this.dgvHorario, this.btnGuardar);
            }
        }

        private void limpiarDatos()
        {
            dsDatos = new DataSet();
            dgvHorario.DataSource = null;
            dgvHorario.Rows.Clear();
            dgvHorario.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listaCB = new ComboBox[] { this.cmbDia, this.cmbHora };
            listaLblCb = new Label[] { this.lblDia, this.lblHora };
            bool combo = ut.seleccionadoCB(listaCB, erpErrorCB, listaLblCb);

            try
            {
                //valor que tiene la celda seleccionada
                var valor = this.dgvHorario.CurrentCell.Value;

                //Si no ha seleccionado los valores necesarios se lo indicamos
                if (!combo)
                {
                    MessageBox.Show("Tiene que insertar un valor en los campos obligatorios",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (string.IsNullOrEmpty(valor.ToString())) //Si esta vacio le indicamos que no se puede borrar
                {
                    MessageBox.Show("Nada que borrar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Borrado de la celada actual y de su tooltip
                    this.dgvHorario.Rows[this.cmbHora.SelectedIndex].Cells[this.cmbDia.SelectedIndex + 1].Value = "";
                    this.ut.deleteToolTip(this.dgvHorario, this.cmbHora, this.lsbModulo, this.cmbDia);
                    this.btnGuardar.Enabled = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Seleciona un campo valido para borrar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ut.generarXML(this.guardar, this.dgvHorario);
            limpiarDatos();
            ut.crearTabla(this.dsDatos, this.dgvHorario);
            this.lsbCiclo.Enabled = true;
            this.cmbCurso.Enabled = true;
        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHorario.Rows[cmbHora.SelectedIndex].Cells[cmbDia.SelectedIndex + 1].Selected = true;
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvHorario.CellClick -= dgvHorario_CellClick;
                dgvHorario.Rows[cmbHora.SelectedIndex].Cells[cmbDia.SelectedIndex + 1].Selected = true;
            }
            catch (Exception)
            {
            }
            finally
            {
                dgvHorario.CellClick += dgvHorario_CellClick;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ut.crearTabla(this.dsDatos, this.dgvHorario);
        }
    }
}
