
namespace ValidarCampos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_VerDatos = new System.Windows.Forms.Button();
            this.btn_Archivar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Validar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTXT_Movil = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.mskTXT_Matricula = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTXT_NIF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTXT_NumCuenta = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VerDatos
            // 
            this.btn_VerDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerDatos.Location = new System.Drawing.Point(33, 397);
            this.btn_VerDatos.Name = "btn_VerDatos";
            this.btn_VerDatos.Size = new System.Drawing.Size(357, 41);
            this.btn_VerDatos.TabIndex = 0;
            this.btn_VerDatos.Text = "Ver datos archivados";
            this.btn_VerDatos.UseVisualStyleBackColor = true;
            this.btn_VerDatos.Click += new System.EventHandler(this.btn_VerDatos_Click);
            // 
            // btn_Archivar
            // 
            this.btn_Archivar.Enabled = false;
            this.btn_Archivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archivar.Location = new System.Drawing.Point(33, 336);
            this.btn_Archivar.Name = "btn_Archivar";
            this.btn_Archivar.Size = new System.Drawing.Size(134, 41);
            this.btn_Archivar.TabIndex = 1;
            this.btn_Archivar.Text = "Archivar";
            this.btn_Archivar.UseVisualStyleBackColor = true;
            this.btn_Archivar.Click += new System.EventHandler(this.btn_Archivar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // btn_Validar
            // 
            this.btn_Validar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Validar.Location = new System.Drawing.Point(256, 336);
            this.btn_Validar.Name = "btn_Validar";
            this.btn_Validar.Size = new System.Drawing.Size(134, 41);
            this.btn_Validar.TabIndex = 4;
            this.btn_Validar.Text = "Validar";
            this.btn_Validar.UseVisualStyleBackColor = true;
            this.btn_Validar.Click += new System.EventHandler(this.btn_Validar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(113, 19);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(293, 27);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(113, 60);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(293, 27);
            this.txt_Apellidos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos:";
            // 
            // mskTXT_Movil
            // 
            this.mskTXT_Movil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTXT_Movil.Location = new System.Drawing.Point(113, 101);
            this.mskTXT_Movil.Mask = "999-999-999";
            this.mskTXT_Movil.Name = "mskTXT_Movil";
            this.mskTXT_Movil.Size = new System.Drawing.Size(293, 27);
            this.mskTXT_Movil.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Móvil:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(113, 142);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(293, 27);
            this.txt_Email.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email: ";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // mskTXT_Matricula
            // 
            this.mskTXT_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTXT_Matricula.Location = new System.Drawing.Point(175, 183);
            this.mskTXT_Matricula.Mask = "9999-LLL";
            this.mskTXT_Matricula.Name = "mskTXT_Matricula";
            this.mskTXT_Matricula.Size = new System.Drawing.Size(231, 27);
            this.mskTXT_Matricula.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Matricula coche:";
            // 
            // mskTXT_NIF
            // 
            this.mskTXT_NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTXT_NIF.Location = new System.Drawing.Point(113, 224);
            this.mskTXT_NIF.Mask = "99999999L";
            this.mskTXT_NIF.Name = "mskTXT_NIF";
            this.mskTXT_NIF.Size = new System.Drawing.Size(293, 27);
            this.mskTXT_NIF.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "NIF:";
            // 
            // mskTXT_NumCuenta
            // 
            this.mskTXT_NumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTXT_NumCuenta.Location = new System.Drawing.Point(157, 265);
            this.mskTXT_NumCuenta.Mask = "ES99 9999 9999 99 9999999999";
            this.mskTXT_NumCuenta.Name = "mskTXT_NumCuenta";
            this.mskTXT_NumCuenta.Size = new System.Drawing.Size(249, 27);
            this.mskTXT_NumCuenta.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nº de cuenta: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskTXT_NumCuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTXT_NIF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTXT_Matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTXT_Movil);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Validar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Archivar);
            this.Controls.Add(this.btn_VerDatos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VerDatos;
        private System.Windows.Forms.Button btn_Archivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Validar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTXT_Movil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.MaskedTextBox mskTXT_Matricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTXT_NIF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTXT_NumCuenta;
        private System.Windows.Forms.Label label7;
    }
}

