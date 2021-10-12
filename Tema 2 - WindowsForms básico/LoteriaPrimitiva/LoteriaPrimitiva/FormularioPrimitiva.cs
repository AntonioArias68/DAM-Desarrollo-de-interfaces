using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaPrimitiva
{
    public partial class FormularioPrimitiva : Form
    {
        public FormularioPrimitiva()
        {
            InitializeComponent();
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstNumeros.CheckedItems.Count != 6)
            {
                MessageBox.Show("Selecciones 6 números para poder jugar la primitiva");
            }
            else
            {
                lstNumeros.Enabled = false;
                btnNuevaApuesta.Enabled = true;
                int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0;
                var rand = new Random();
                int[] numeros;
                generarNumerosLoteria(out n1, out n2, out n3, out n4, out n5, out n6, rand, out numeros);
                txt_Numero1.Text = numeros[0].ToString();
                txt_Numero2.Text = numeros[1].ToString();
                txt_Numero3.Text = numeros[2].ToString();
                txt_Numero4.Text = numeros[3].ToString();
                txt_Numero5.Text = numeros[4].ToString();
                txt_Numero6.Text = numeros[5].ToString();
                comprobarAciertos(numeros);
                btnJugar.Enabled = false;
            }
        }

        private static void generarNumerosLoteria(out int n1, out int n2, out int n3, out int n4, out int n5, out int n6, Random rand, out int[] numeros)
        {
            do
            {
                n1 = rand.Next(1, 49);
                n2 = rand.Next(1, 49);
                n3 = rand.Next(1, 49);
                n4 = rand.Next(1, 49);
                n5 = rand.Next(1, 49);
                n6 = rand.Next(1, 49);
            } while (n1 == n2 || n1 == n2 || n1 == n3 || n1 == n4 || n1 == n5 || n1 == n6 ||
                     n2 == n1 || n2 == n3 || n2 == n4 || n1 == n5 || n1 == n6 ||
                     n3 == n1 || n3 == n2 || n3 == n4 || n3 == n5 || n3 == n6 ||
                     n4 == n1 || n4 == n2 || n4 == n3 || n4 == n5 || n4 == n6 ||
                     n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4 || n5 == n6 ||
                     n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4 || n6 == n5);

            numeros = new int[6];
            numeros[0] = n1;
            numeros[1] = n2;
            numeros[2] = n3;
            numeros[3] = n4;
            numeros[4] = n5;
            numeros[5] = n6;

            Array.Sort(numeros);
        }

        private void comprobarAciertos(int[] numeros)
        {
            int aciertos = 0;
            for (int i = lstNumeros.CheckedItems.Count - 1; i >= 0; i--)
            {
                foreach (int n in numeros)
                {
                    if (int.Parse(lstNumeros.CheckedItems[i].ToString()) == n)
                    {
                        aciertos++;
                    }
                }
            }
            txtAciertos.Text = aciertos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstNumeros.Enabled = true;
            limpiarCheckedList();
            limpiarTextBox();
            btnNuevaApuesta.Enabled = false;
            btnJugar.Enabled = true;
        }

        private void limpiarTextBox()
        {
            txtAciertos.Text = "";
            txt_Numero1.Text = "";
            txt_Numero2.Text = "";
            txt_Numero3.Text = "";
            txt_Numero4.Text = "";
            txt_Numero5.Text = "";
            txt_Numero6.Text = "";
        }

        private void limpiarCheckedList()
        {
            for (int i = 0; i < lstNumeros.Items.Count; i++)
            {
                lstNumeros.SetItemChecked(i, false);
            }
        }
    }
}
