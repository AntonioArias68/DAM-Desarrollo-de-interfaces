using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Horarios
{
    class Utilidades
    {
        internal void crearTabla(DataSet dsDatos, DataGridView dgvHorario)
        {
            dsDatos.Clear();
            dsDatos.Reset();
            dsDatos.Tables.Add(new DataTable("horario"));
            dsDatos.Tables[0].Columns.Add("HORA");
            dsDatos.Tables[0].Columns.Add("LUNES");
            dsDatos.Tables[0].Columns.Add("MARTES");
            dsDatos.Tables[0].Columns.Add("MIERCOLES");
            dsDatos.Tables[0].Columns.Add("JUEVES");
            dsDatos.Tables[0].Columns.Add("VIERNES");
            datosIniciales(dsDatos);
            dgvHorario.DataSource = dsDatos.Tables[0];
            tablaFija(dgvHorario);
        }

        internal void cambiarAsig(ListBox lsbModulo, ListBox lsbCiclo, ComboBox cmbCurso)
        {
            string[] segundoDam = {"Acc. Datos", "Desarrollo de Interfaces", "Sist. Gest. Empr.", "Empr. Ini. Empre.", "Prog. Serv. Proc", "Prog. Mult. Y Dispo. Móv."};
            string[] segundoDaw = { "Des. Web Cli.", "Des. Web Serv.", "Empr. Ini. Empre.", "Desp. App. Web", "Dis. Int. Web"};
            string[] primero = {"Programación", "Base de datos", "Ent. Des.", "Sist. Inf.","Leng. Marcas", "FOL", "Inglés"};

            int op = comprobarCursoCiclo(lsbModulo, lsbCiclo, cmbCurso);
            switch (op)
            {

                case 1: //PrimeroDAM y PrimeroDAW
                    lsbModulo.Items.Clear();
                    for (int i = 0; i < primero.Length; i++)
                    {
                        lsbModulo.Items.Add(primero[i]);
                    }
                    break;

                case 2: //SegundoDAM

                    lsbModulo.Items.Clear();
                    for (int i = 0; i < segundoDam.Length; i++)
                    {
                        lsbModulo.Items.Add(segundoDam[i]);
                    }
                    break;

                case 3: //SegundoDAW

                    lsbModulo.Items.Clear();
                    for (int i = 0; i < segundoDaw.Length; i++)
                    {
                        lsbModulo.Items.Add(segundoDaw[i]);
                    }
                    break;

                default:
                    break;
            }
        }

        internal void addAsignatura(DataGridView dgvHorario, ComboBox cmbCurso, ListBox lsbModulo, ListBox lsbCiclo)
        {
            string modulo = lsbModulo.Text;
            dgvHorario.CurrentCell.Value = modulo;
            addToolTip(dgvHorario, cmbCurso, lsbCiclo, lsbModulo);
        }

        private void addToolTip(DataGridView dgvHorario, ComboBox cmbCurso, ListBox lsbCiclo, ListBox lsbModulo)
        {
            string[] tooltipSegundoDam = { "Joaquín - Aula 209", "José Alberto - Aula 209", "Inmaculada - Aula 209",
                "Ambrosio - Aula 209", "Marcelo - Aula 209", "Fernando - Aula 209" };
            string[] tooltipSegundoDaw = { "Inmaculada - Aula 206", "Fernando - Aula 206", "Ambrosio - Aula 209",
                "Profesor 1 - Aula 209",  "Profesor 2 - Aula 209" };
            string[] tooltipPrimeroDaw = { "Fernando - Aula 212","Alicia - Aula 212",  "Fernando - Aula 212",
                "Jaime - Aula 212",  "Alicia - Aula 212", "Profesor 4 - Aula 212", "Teresa - Aula 212" };
            string[] tooltipPrimeroDam = { "Profesor 3 - Aula 213","Alicia - Aula 213",  "Marciano - Aula 213",
                "Jaime - Aula 213",  "Alicia - Aula 213", "Maria - Aula 213", "Teresa - Aula 213" };

            int op = comprobarCursoCiclo(lsbModulo, lsbCiclo, cmbCurso);

            switch (op)
            {
                case 1: //PrimeroDAM

                    dgvHorario.CurrentCell.ToolTipText = tooltipPrimeroDam[lsbModulo.SelectedIndex];
                    break;
                case 2: //SegundoDAM
                    dgvHorario.CurrentCell.ToolTipText = tooltipSegundoDam[lsbModulo.SelectedIndex];
                    break;
                case 3: //PrimeroDAW
                    dgvHorario.CurrentCell.ToolTipText = tooltipPrimeroDaw[lsbModulo.SelectedIndex];
                    break;
                case 4: //SegundoDAW
                    dgvHorario.CurrentCell.ToolTipText = tooltipSegundoDaw[lsbModulo.SelectedIndex];
                    break;
                default:
                    break;
            }
        }

        internal void tablaCompleta(DataGridView dgvHorario, Button btnGuardar)
        {
            bool vacio = false;

            foreach (DataGridViewRow dgvr in dgvHorario.Rows)
            {
                foreach (DataGridViewCell dgvc in dgvr.Cells)
                {
                    if (string.IsNullOrEmpty(dgvc.Value.ToString()))
                    {
                        btnGuardar.Enabled = false;
                        vacio = true;
                        break;

                    }
                }
                if (vacio) { break; }
            }
            if (!vacio) { btnGuardar.Enabled = true; }
        }
        internal bool seleccionadoLB(ListBox[] listaLB, ErrorProvider erpError, Label[] listaLblLb)
        {
            bool todo = false;
            int contLB = 0;

            erpError.Clear();

            for (int i = 0; i < listaLB.Length; i++)
            {
                if (!errorProviderLB(listaLB[i], erpError, listaLblLb[i]))
                {
                    contLB++;
                    if (contLB == listaLB.Length) { todo = true; }
                }
            }

            return todo;
        }

        private bool errorProviderLB(ListBox listBox, ErrorProvider erpError, Label label)
        {
            bool error = false;

            if (listBox.SelectedIndex < 0)
            {
                error = true;
                erpError.SetError(label, "Debes seleccionar un valor");
            }

            return error;
        }

        internal bool seleccionadoCB(ComboBox[] listaCB, ErrorProvider erpError, Label[] listaLblCb)
        {
            bool todo = false;
            int contCB = 0;

            erpError.Clear();

            for (int i = 0; i < listaCB.Length; i++)
            {
                if (!errorProviderCB(listaCB[i], erpError, listaLblCb[i]))
                {
                    contCB++;
                    if (contCB == listaCB.Length) { todo = true; }
                }
            }

            return todo;
        }

        private bool errorProviderCB(ComboBox comboBox, ErrorProvider erpError, Label label)
        {
            bool error = false;

            if (comboBox.SelectedIndex < 0)
            {
                error = true;
                erpError.SetError(label, "Debes seleccionar un valor");
            }

            return error;
        }

        private int comprobarCursoCiclo(ListBox lsbModulo, ListBox lsbCiclo, ComboBox cmbCurso)
        {
            int curso = 0;

            if (lsbCiclo.SelectedItem != null && cmbCurso.SelectedItem != null)
            {
                if (lsbCiclo.SelectedItem.ToString().Equals("DAM"))
                {
                    if (cmbCurso.SelectedItem.ToString().Equals("Primero")) { curso = 1; }
                    else { curso = 2; }

                }
                else if (lsbCiclo.SelectedItem.ToString().Equals("DAW"))
                {
                    if (cmbCurso.SelectedItem.ToString().Equals("Primero")) { curso = 1; }
                    else { curso = 3; }
                }
            }

            return curso;
        }

        private void datosIniciales(DataSet dsDatos)
        {
            string[] horas = new string[] 
            { 
                "8:30 - 9:25",
                "9:25 - 10:20",
                "10:20 - 11:15",
                "11:45 - 12:40",
                "12:40 - 13:35",
                "13:35 - 14:30"
            };

            for (int i = 0; i < horas.Length; i++) 
            {
                dsDatos.Tables[0].Rows.Add(horas[i]);
            }
        }

        internal void generarXML(SaveFileDialog guardar, DataGridView dgvHorario)
        {
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                //se crea el elemento raíz y se asocia al documento
                XmlDocument xDoc = new XmlDocument();
                XmlElement elementoRaiz = xDoc.CreateElement(string.Empty, "horario", string.Empty);
                xDoc.AppendChild(elementoRaiz);

                for (int i = 0; i < dgvHorario.Rows.Count; i++)
                {
                    XmlElement xHora = xDoc.CreateElement(string.Empty, "hora", string.Empty);
                    //El atributo id con la hora se puede sacar de la primera columna del DataGridView
                    xHora.SetAttribute("id", dgvHorario.Rows[i].Cells[0].Value.ToString());

                    for (int j = 1; j < dgvHorario.Columns.Count; j++)
                    {
                        XmlElement xDia = xDoc.CreateElement(string.Empty, "dia", string.Empty);
                        XmlElement xAsignatura = xDoc.CreateElement(string.Empty, "asignatura", string.Empty);
                        XmlElement xAyuda = xDoc.CreateElement(string.Empty, "ayuda", string.Empty);

                        XmlText xTxAsignatura = xDoc.CreateTextNode(dgvHorario.Rows[i].Cells[j].Value.ToString());
                        xAsignatura.AppendChild(xTxAsignatura);
                        XmlText xTxAyuda = xDoc.CreateTextNode(dgvHorario.Rows[i].Cells[j].ToolTipText);
                        xAyuda.AppendChild(xTxAyuda);

                        xDia.AppendChild(xAsignatura);
                        xDia.AppendChild(xAyuda);
                        xHora.AppendChild(xDia);
                    }

                    elementoRaiz.AppendChild(xHora);

                }

                //Ahora vamos a guardar el documento con formato correcto (suponiendo que la ruta la
                //devuelve el SaveFileDialog sfdGuardar
                XmlTextWriter xtw = new XmlTextWriter(guardar.FileName, Encoding.UTF8);
                xtw.Formatting = Formatting.Indented;
                xDoc.Save(xtw);
                xtw.Close();
                MessageBox.Show("Se ha guardado con exito el horario",
                    "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal void deleteToolTip(DataGridView dgvHorario, ComboBox cmbHora, ListBox lsbModulo, ComboBox cmbDia)
        {
            dgvHorario.CurrentCell.ToolTipText = null;
        }

        private void tablaFija(DataGridView dgvHorario)
        {
            foreach (DataGridViewColumn column in dgvHorario.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Resizable = DataGridViewTriState.False;
            }
        }
    }
}
