using IbanNet;
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
    public partial class Form1 : Form
    {

        string rutaArchivo = "RegistrosBancarios.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            epError.Clear();
            if (validarFormularios())
            {
                btn_Archivar.Enabled = true;
            }
        }

        private bool validarFormularios()
        {

            if (camposRellenos())
            {
                validacionEmail();
                validacionDNI();
                validacionIBAN();

                return true;

            }
            else
            {
                return false;
            }
        }

        private void validacionEmail()
        {
            try
            {
                if (!isEmailValido(txt_Email))
                {
                    btn_Archivar.Enabled = false;
                    throw new Email_Exception("El email no es válido");
                }
            }
            catch (Email_Exception e_ex)
            {
                epError.SetError(txt_Email, e_ex.Msg);
            }
        }

        private void validacionDNI()
        {
            try
            {
                if (!isDNIValido(mskTXT_NIF))
                {
                    btn_Archivar.Enabled = false;
                    throw new DNI_Exception("El DNI no es válido");
                }
            }
            catch (DNI_Exception dni_ex)
            {
                epError.SetError(mskTXT_NIF, dni_ex.Msg);
            }
        }

        private void validacionIBAN()
        {
            try
            {
                if (!isCuentaValida(mskTXT_NumCuenta))
                {
                    btn_Archivar.Enabled = false;
                    throw new IBAN_Exception("El IBAN no es válido");
                }
            }
            catch (IBAN_Exception i_ex)
            {
                epError.SetError(mskTXT_NumCuenta, i_ex.Msg);
            }
        }

        private bool isCuentaValida(MaskedTextBox mskCuenta)
        {
            string cuenta = mskCuenta.Text;
            cuenta = mskCuenta.Text.Replace("-", "");
            cuenta = mskCuenta.Text.Replace(",", "");
            cuenta = mskCuenta.Text.Replace(".", "");

            if (CheckIban(cuenta))
            {
                //Iban valido
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckIban(string iban)
        {
            //Función para calcular si es valido el iban. 

            IbanValidator validator = new IbanValidator();
            var validationResult = validator.Validate(iban);

            return validationResult.IsValid;
        }
        private bool isDNIValido(MaskedTextBox msk_dni)
        {
            string dni = msk_dni.Text;
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                return false;
            }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalcularLetraDNI(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido :)
            return true;
        }

        static string CalcularLetraDNI(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }
        private bool isEmailValido(TextBox txt)
        {
            try
            {
                string email = txt.Text;
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool camposRellenos()
        {
            epError.Clear();    

            if(!isCampoRelleno(txt_Nombre) || !isCampoRelleno(txt_Apellidos) || !isCampoRelleno(txt_Email)
                || !isMaskCompleta(mskTXT_Movil) || !isMaskCompleta(mskTXT_Matricula) 
                || !isMaskCompleta(mskTXT_NIF) || !isMaskCompleta(mskTXT_NumCuenta))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isMaskCompleta(MaskedTextBox msk)
        {
            if (msk.MaskFull)
            {
                return true;
            }
            else
            {
                epError.SetError(msk, "Termine de completar el campo");
                return false;
            }
        }

        private bool isCampoRelleno(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                epError.SetError(txt, "Relleno el campo solicitado");
                return false;
            }
            else
            {                
                return true;
            }
        }

        private void btn_Archivar_Click(object sender, EventArgs e)
        {
            bool valido = false;

            if (!isIBANRegistrado(mskTXT_NumCuenta))
            {
                valido = true;
            }

            if (!isMatriculaRegistrada(mskTXT_Matricula))
            {
                valido = true;
            }

            if (valido)
            {
                GuardarRegistro();
                LimpiarFormulario();
            }

        }

        private bool isIBANRegistrado(MaskedTextBox iban)
        {
            if (File.ReadAllText(rutaArchivo).Contains(iban.Text.ToString()))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El IBAN ya ha sido registrado anteriormente");
                return false;
            }
        }

        private bool isMatriculaRegistrada(MaskedTextBox matricula)
        {
            if (File.ReadAllText(rutaArchivo).Contains(matricula.Text.ToString()))
            {
                return true;
            }
            else
            {
                MessageBox.Show("La matrícula ya ha sido registrada anteriormente");
                return false;
            }
        }

        private void LimpiarFormulario()
        {
            txt_Nombre.Clear();
            txt_Apellidos.Clear();
            txt_Email.Clear();
            mskTXT_Matricula.Clear();
            mskTXT_Movil.Clear();
            mskTXT_NIF.Clear();
            mskTXT_NumCuenta.Clear();
        }

        private void GuardarRegistro()
        {
            StreamWriter texto = new StreamWriter(rutaArchivo, true);
            texto.WriteLine("*********************** REGISTRO ***********************");
            texto.WriteLine("Nº Cuenta: " + mskTXT_NumCuenta.Text);
            texto.WriteLine("Nombre: " + txt_Nombre.Text);
            texto.WriteLine("Apellidos: " + txt_Apellidos.Text);
            texto.WriteLine("DNI: " + mskTXT_NIF.Text);
            texto.WriteLine("Teléfono: " + mskTXT_Movil.Text);
            texto.WriteLine("Email: " + txt_Email.Text);
            texto.WriteLine("Matrícula: " + mskTXT_Matricula.Text);
            texto.WriteLine("********************************************************");
            texto.WriteLine();
            texto.Close();
        }

        private void btn_VerDatos_Click(object sender, EventArgs e)
        {
            VerDatos form = new VerDatos();
            form.ShowDialog();
        }
    }
}
