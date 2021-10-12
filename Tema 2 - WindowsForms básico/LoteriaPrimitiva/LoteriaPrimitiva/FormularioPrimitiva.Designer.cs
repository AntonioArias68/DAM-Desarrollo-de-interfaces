
namespace LoteriaPrimitiva
{
    partial class FormularioPrimitiva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstNumeros = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaApuesta = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.txt_Numero3 = new System.Windows.Forms.TextBox();
            this.txt_Numero6 = new System.Windows.Forms.TextBox();
            this.txt_Numero5 = new System.Windows.Forms.TextBox();
            this.txt_Numero4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciertos = new System.Windows.Forms.TextBox();
            this.bntSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstNumeros.CheckOnClick = true;
            this.lstNumeros.ColumnWidth = 100;
            this.lstNumeros.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumeros.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49"});
            this.lstNumeros.Location = new System.Drawing.Point(13, 13);
            this.lstNumeros.Margin = new System.Windows.Forms.Padding(4);
            this.lstNumeros.MultiColumn = true;
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(611, 250);
            this.lstNumeros.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(681, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 100);
            this.label1.TabIndex = 34;
            this.label1.Text = "Selecciona los\r\nseis números con\r\nlos que quieres\r\njugar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevaApuesta
            // 
            this.btnNuevaApuesta.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnNuevaApuesta.Enabled = false;
            this.btnNuevaApuesta.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaApuesta.Location = new System.Drawing.Point(38, 270);
            this.btnNuevaApuesta.Name = "btnNuevaApuesta";
            this.btnNuevaApuesta.Size = new System.Drawing.Size(310, 60);
            this.btnNuevaApuesta.TabIndex = 35;
            this.btnNuevaApuesta.Text = "NUEVA APUESTA";
            this.btnNuevaApuesta.UseVisualStyleBackColor = false;
            this.btnNuevaApuesta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(586, 270);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(181, 60);
            this.btnJugar.TabIndex = 36;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_Numero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Numero1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero1.Location = new System.Drawing.Point(75, 382);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.ReadOnly = true;
            this.txt_Numero1.Size = new System.Drawing.Size(84, 44);
            this.txt_Numero1.TabIndex = 37;
            this.txt_Numero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_Numero2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Numero2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero2.Location = new System.Drawing.Point(221, 382);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.ReadOnly = true;
            this.txt_Numero2.Size = new System.Drawing.Size(84, 44);
            this.txt_Numero2.TabIndex = 38;
            this.txt_Numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Numero3
            // 
            this.txt_Numero3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_Numero3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Numero3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero3.Location = new System.Drawing.Point(388, 382);
            this.txt_Numero3.Name = "txt_Numero3";
            this.txt_Numero3.ReadOnly = true;
            this.txt_Numero3.Size = new System.Drawing.Size(84, 44);
            this.txt_Numero3.TabIndex = 39;
            this.txt_Numero3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Numero6
            // 
            this.txt_Numero6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_Numero6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Numero6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero6.Location = new System.Drawing.Point(853, 382);
            this.txt_Numero6.Name = "txt_Numero6";
            this.txt_Numero6.ReadOnly = true;
            this.txt_Numero6.Size = new System.Drawing.Size(84, 44);
            this.txt_Numero6.TabIndex = 42;
            this.txt_Numero6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Numero5
            // 
            this.txt_Numero5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_Numero5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Numero5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero5.Location = new System.Drawing.Point(686, 382);
            this.txt_Numero5.Name = "txt_Numero5";
            this.txt_Numero5.ReadOnly = true;
            this.txt_Numero5.Size = new System.Drawing.Size(84, 44);
            this.txt_Numero5.TabIndex = 41;
            this.txt_Numero5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Numero4
            // 
            this.txt_Numero4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_Numero4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Numero4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero4.Location = new System.Drawing.Point(540, 382);
            this.txt_Numero4.Name = "txt_Numero4";
            this.txt_Numero4.ReadOnly = true;
            this.txt_Numero4.Size = new System.Drawing.Size(84, 44);
            this.txt_Numero4.TabIndex = 40;
            this.txt_Numero4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Números que han salido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cantidad de aciertos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAciertos
            // 
            this.txtAciertos.BackColor = System.Drawing.Color.LightSalmon;
            this.txtAciertos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAciertos.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAciertos.Location = new System.Drawing.Point(284, 445);
            this.txtAciertos.Name = "txtAciertos";
            this.txtAciertos.ReadOnly = true;
            this.txtAciertos.Size = new System.Drawing.Size(84, 44);
            this.txtAciertos.TabIndex = 45;
            this.txtAciertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntSalir
            // 
            this.bntSalir.BackColor = System.Drawing.Color.MistyRose;
            this.bntSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalir.Location = new System.Drawing.Point(888, 453);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(75, 41);
            this.bntSalir.TabIndex = 46;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = false;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // FormularioPrimitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 519);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.txtAciertos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Numero6);
            this.Controls.Add(this.txt_Numero5);
            this.Controls.Add(this.txt_Numero4);
            this.Controls.Add(this.txt_Numero3);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnNuevaApuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPrimitiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrimitiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaApuesta;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.TextBox txt_Numero3;
        private System.Windows.Forms.TextBox txt_Numero6;
        private System.Windows.Forms.TextBox txt_Numero5;
        private System.Windows.Forms.TextBox txt_Numero4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciertos;
        private System.Windows.Forms.Button bntSalir;
    }
}