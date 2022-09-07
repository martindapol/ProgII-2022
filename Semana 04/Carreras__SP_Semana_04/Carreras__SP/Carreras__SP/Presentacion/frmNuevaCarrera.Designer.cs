namespace Carreras__SP.Presentacion
{
    partial class frmNuevaCarrera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.IdAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbnSegundoCuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbnPrimerCuatrimestre = new System.Windows.Forms.RadioButton();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Datos de la materia";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(425, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 30);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(199, 417);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 30);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAsignatura,
            this.NombreAsignatura,
            this.AnioCursado,
            this.Cuatrimestre,
            this.Eliminar});
            this.dgvDetalles.Location = new System.Drawing.Point(69, 261);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(673, 131);
            this.dgvDetalles.TabIndex = 27;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // IdAsignatura
            // 
            this.IdAsignatura.HeaderText = "Id Asignatura";
            this.IdAsignatura.Name = "IdAsignatura";
            this.IdAsignatura.ReadOnly = true;
            this.IdAsignatura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NombreAsignatura
            // 
            this.NombreAsignatura.HeaderText = "Nombre Asignatura";
            this.NombreAsignatura.Name = "NombreAsignatura";
            this.NombreAsignatura.ReadOnly = true;
            this.NombreAsignatura.Width = 200;
            // 
            // AnioCursado
            // 
            this.AnioCursado.HeaderText = "Año cursado";
            this.AnioCursado.Name = "AnioCursado";
            this.AnioCursado.ReadOnly = true;
            this.AnioCursado.Width = 120;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            this.Cuatrimestre.Width = 120;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // rbnSegundoCuatrimestre
            // 
            this.rbnSegundoCuatrimestre.AutoSize = true;
            this.rbnSegundoCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSegundoCuatrimestre.Location = new System.Drawing.Point(437, 180);
            this.rbnSegundoCuatrimestre.Name = "rbnSegundoCuatrimestre";
            this.rbnSegundoCuatrimestre.Size = new System.Drawing.Size(158, 20);
            this.rbnSegundoCuatrimestre.TabIndex = 26;
            this.rbnSegundoCuatrimestre.TabStop = true;
            this.rbnSegundoCuatrimestre.Text = "Segundo Cuatrimestre";
            this.rbnSegundoCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbnPrimerCuatrimestre
            // 
            this.rbnPrimerCuatrimestre.AutoSize = true;
            this.rbnPrimerCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPrimerCuatrimestre.Location = new System.Drawing.Point(437, 132);
            this.rbnPrimerCuatrimestre.Name = "rbnPrimerCuatrimestre";
            this.rbnPrimerCuatrimestre.Size = new System.Drawing.Size(151, 21);
            this.rbnPrimerCuatrimestre.TabIndex = 25;
            this.rbnPrimerCuatrimestre.TabStop = true;
            this.rbnPrimerCuatrimestre.Text = "Primer Cuatrimestre";
            this.rbnPrimerCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(296, 216);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(163, 30);
            this.btnAgregarDetalle.TabIndex = 24;
            this.btnAgregarDetalle.Text = "Agregar Detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(176, 178);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(167, 20);
            this.txtAnioCursado.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Año de Cursado";
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(176, 134);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(167, 21);
            this.cboMaterias.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Materia";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(176, 60);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(243, 20);
            this.txtNombreCarrera.TabIndex = 19;
            this.txtNombreCarrera.TextChanged += new System.EventHandler(this.txtNombreCarrera_TextChanged);
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCarrera.Location = new System.Drawing.Point(33, 61);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(137, 16);
            this.lblNombreCarrera.TabIndex = 18;
            this.lblNombreCarrera.Text = "Nombre de la Carrera";
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(235, 21);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(108, 16);
            this.lblNuevaCarrera.TabIndex = 17;
            this.lblNuevaCarrera.Text = "Nueva Carrera";
            // 
            // frmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.rbnSegundoCuatrimestre);
            this.Controls.Add(this.rbnPrimerCuatrimestre);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Name = "frmNuevaCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaCarrera";
            this.Load += new System.EventHandler(this.frmNuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.RadioButton rbnSegundoCuatrimestre;
        private System.Windows.Forms.RadioButton rbnPrimerCuatrimestre;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}