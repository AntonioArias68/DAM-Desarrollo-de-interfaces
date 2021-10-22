
namespace Alumnos
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.rtbEsquema = new System.Windows.Forms.RichTextBox();
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.btnEsquema = new System.Windows.Forms.Button();
            this.btnTeléfonos = new System.Windows.Forms.Button();
            this.btnFichero = new System.Windows.Forms.Button();
            this.btnGuardarXML = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.dsDatos = new System.Data.DataSet();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 13);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(1033, 283);
            this.dgvDatos.TabIndex = 0;
            // 
            // rtbEsquema
            // 
            this.rtbEsquema.Location = new System.Drawing.Point(12, 302);
            this.rtbEsquema.Name = "rtbEsquema";
            this.rtbEsquema.Size = new System.Drawing.Size(1033, 283);
            this.rtbEsquema.TabIndex = 1;
            this.rtbEsquema.Text = "";
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerXML.Location = new System.Drawing.Point(80, 602);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(152, 43);
            this.btnLeerXML.TabIndex = 2;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // btnEsquema
            // 
            this.btnEsquema.Enabled = false;
            this.btnEsquema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsquema.Location = new System.Drawing.Point(274, 602);
            this.btnEsquema.Name = "btnEsquema";
            this.btnEsquema.Size = new System.Drawing.Size(149, 43);
            this.btnEsquema.TabIndex = 3;
            this.btnEsquema.Text = "Mostrar esquema";
            this.btnEsquema.UseVisualStyleBackColor = true;
            this.btnEsquema.Click += new System.EventHandler(this.btnEsquema_Click);
            // 
            // btnTeléfonos
            // 
            this.btnTeléfonos.Enabled = false;
            this.btnTeléfonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeléfonos.Location = new System.Drawing.Point(474, 602);
            this.btnTeléfonos.Name = "btnTeléfonos";
            this.btnTeléfonos.Size = new System.Drawing.Size(150, 43);
            this.btnTeléfonos.TabIndex = 4;
            this.btnTeléfonos.Text = "Teléfonos";
            this.btnTeléfonos.UseVisualStyleBackColor = true;
            this.btnTeléfonos.Click += new System.EventHandler(this.btnTeléfonos_Click);
            // 
            // btnFichero
            // 
            this.btnFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichero.Location = new System.Drawing.Point(663, 602);
            this.btnFichero.Name = "btnFichero";
            this.btnFichero.Size = new System.Drawing.Size(150, 43);
            this.btnFichero.TabIndex = 5;
            this.btnFichero.Text = "Fich, generado";
            this.btnFichero.UseVisualStyleBackColor = true;
            this.btnFichero.Click += new System.EventHandler(this.btnFichero_Click);
            // 
            // btnGuardarXML
            // 
            this.btnGuardarXML.Enabled = false;
            this.btnGuardarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarXML.Location = new System.Drawing.Point(850, 602);
            this.btnGuardarXML.Name = "btnGuardarXML";
            this.btnGuardarXML.Size = new System.Drawing.Size(150, 43);
            this.btnGuardarXML.TabIndex = 6;
            this.btnGuardarXML.Text = "Guardar XML";
            this.btnGuardarXML.UseVisualStyleBackColor = true;
            this.btnGuardarXML.Click += new System.EventHandler(this.btnGuardarXML_Click);
            // 
            // abrir
            // 
            this.abrir.FileName = "openFileDialog1";
            this.abrir.Filter = "Documento XML(*.xml) | *.xml";
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1058, 657);
            this.Controls.Add(this.btnGuardarXML);
            this.Controls.Add(this.btnFichero);
            this.Controls.Add(this.btnTeléfonos);
            this.Controls.Add(this.btnEsquema);
            this.Controls.Add(this.btnLeerXML);
            this.Controls.Add(this.rtbEsquema);
            this.Controls.Add(this.dgvDatos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.RichTextBox rtbEsquema;
        private System.Windows.Forms.Button btnLeerXML;
        private System.Windows.Forms.Button btnEsquema;
        private System.Windows.Forms.Button btnTeléfonos;
        private System.Windows.Forms.Button btnFichero;
        private System.Windows.Forms.Button btnGuardarXML;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Data.DataSet dsDatos;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
    }
}

