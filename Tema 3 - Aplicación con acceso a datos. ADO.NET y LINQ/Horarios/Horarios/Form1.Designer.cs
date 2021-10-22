
namespace Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dsDatos = new System.Data.DataSet();
            this.grbHorario = new System.Windows.Forms.GroupBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.grbDatosCurso = new System.Windows.Forms.GroupBox();
            this.lsbCiclo = new System.Windows.Forms.ListBox();
            this.lsbModulo = new System.Windows.Forms.ListBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.guardar = new System.Windows.Forms.SaveFileDialog();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.erpErrorCB = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpErrorLB = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.grbHorario.SuspendLayout();
            this.grbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrorCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrorLB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(529, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(575, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(45, 383);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(99, 60);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 10;
            this.pcbLogo.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(12, 461);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(161, 37);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar horario";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(12, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar horario";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "NewDataSet";
            // 
            // grbHorario
            // 
            this.grbHorario.Controls.Add(this.cmbDia);
            this.grbHorario.Controls.Add(this.cmbHora);
            this.grbHorario.Controls.Add(this.lblDia);
            this.grbHorario.Controls.Add(this.lblHora);
            this.grbHorario.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHorario.Location = new System.Drawing.Point(12, 195);
            this.grbHorario.Name = "grbHorario";
            this.grbHorario.Size = new System.Drawing.Size(214, 100);
            this.grbHorario.TabIndex = 13;
            this.grbHorario.TabStop = false;
            this.grbHorario.Text = "Horario";
            // 
            // cmbDia
            // 
            this.cmbDia.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.cmbDia.Location = new System.Drawing.Point(73, 65);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(135, 24);
            this.cmbDia.TabIndex = 3;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // cmbHora
            // 
            this.cmbHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "8:30-9:25",
            "9:25-10:20",
            "10:20-11:15",
            "11:45-12:40",
            "12:40-13:35",
            "13:35-14:30"});
            this.cmbHora.Location = new System.Drawing.Point(73, 26);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(135, 24);
            this.cmbHora.TabIndex = 2;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(10, 68);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(26, 16);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Día";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(10, 29);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 16);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // grbDatosCurso
            // 
            this.grbDatosCurso.Controls.Add(this.lsbCiclo);
            this.grbDatosCurso.Controls.Add(this.lsbModulo);
            this.grbDatosCurso.Controls.Add(this.cmbCurso);
            this.grbDatosCurso.Controls.Add(this.lblCurso);
            this.grbDatosCurso.Controls.Add(this.lblModulo);
            this.grbDatosCurso.Controls.Add(this.lblCiclo);
            this.grbDatosCurso.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosCurso.Location = new System.Drawing.Point(232, 192);
            this.grbDatosCurso.Name = "grbDatosCurso";
            this.grbDatosCurso.Size = new System.Drawing.Size(387, 251);
            this.grbDatosCurso.TabIndex = 14;
            this.grbDatosCurso.TabStop = false;
            this.grbDatosCurso.Text = "Datos del Curso";
            // 
            // lsbCiclo
            // 
            this.lsbCiclo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCiclo.FormattingEnabled = true;
            this.lsbCiclo.ItemHeight = 16;
            this.lsbCiclo.Items.AddRange(new object[] {
            "DAM",
            "DAW"});
            this.lsbCiclo.Location = new System.Drawing.Point(25, 62);
            this.lsbCiclo.Name = "lsbCiclo";
            this.lsbCiclo.Size = new System.Drawing.Size(121, 164);
            this.lsbCiclo.TabIndex = 6;
            this.lsbCiclo.SelectedIndexChanged += new System.EventHandler(this.lsbCiclo_SelectedIndexChanged);
            // 
            // lsbModulo
            // 
            this.lsbModulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbModulo.FormattingEnabled = true;
            this.lsbModulo.ItemHeight = 16;
            this.lsbModulo.Location = new System.Drawing.Point(166, 88);
            this.lsbModulo.Name = "lsbModulo";
            this.lsbModulo.Size = new System.Drawing.Size(215, 132);
            this.lsbModulo.TabIndex = 5;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.cmbCurso.Location = new System.Drawing.Point(191, 22);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(137, 24);
            this.cmbCurso.TabIndex = 4;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(117, 30);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(39, 16);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(163, 62);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(55, 16);
            this.lblModulo.TabIndex = 1;
            this.lblModulo.Text = "Módulos";
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(22, 35);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(34, 16);
            this.lblCiclo.TabIndex = 0;
            this.lblCiclo.Text = "Ciclo";
            // 
            // abrir
            // 
            this.abrir.Filter = "Documentos XML (*.xml) | *.xml";
            // 
            // guardar
            // 
            this.guardar.Filter = "Documentos XML (*.xml) | *.xml";
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorario.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Location = new System.Drawing.Point(12, 12);
            this.dgvHorario.MultiSelect = false;
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHorario.Size = new System.Drawing.Size(607, 159);
            this.dgvHorario.TabIndex = 15;
            this.dgvHorario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellClick);
            this.dgvHorario.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellValueChanged);
            // 
            // erpErrorCB
            // 
            this.erpErrorCB.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpErrorCB.ContainerControl = this;
            // 
            // erpErrorLB
            // 
            this.erpErrorLB.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpErrorLB.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(631, 510);
            this.Controls.Add(this.dgvHorario);
            this.Controls.Add(this.grbDatosCurso);
            this.Controls.Add(this.grbHorario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.grbHorario.ResumeLayout(false);
            this.grbHorario.PerformLayout();
            this.grbDatosCurso.ResumeLayout(false);
            this.grbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrorCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrorLB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Data.DataSet dsDatos;
        private System.Windows.Forms.GroupBox grbHorario;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox grbDatosCurso;
        private System.Windows.Forms.ListBox lsbCiclo;
        private System.Windows.Forms.ListBox lsbModulo;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Windows.Forms.SaveFileDialog guardar;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.ErrorProvider erpErrorCB;
        private System.Windows.Forms.ErrorProvider erpErrorLB;
    }
}

