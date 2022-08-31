namespace Carreras_SP
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
            this.components = new System.ComponentModel.Container();
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.rbnPrimerCuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbnSegundoCuatrimestre = new System.Windows.Forms.RadioButton();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.carrerasBD_LocalDataSet = new Carreras_SP.CarrerasBD_LocalDataSet();
            this.carrerasBDLocalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBD_LocalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBDLocalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(232, 18);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(108, 16);
            this.lblNuevaCarrera.TabIndex = 0;
            this.lblNuevaCarrera.Text = "Nueva Carrera";
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCarrera.Location = new System.Drawing.Point(30, 58);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(137, 16);
            this.lblNombreCarrera.TabIndex = 1;
            this.lblNombreCarrera.Text = "Nombre de la Carrera";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(173, 57);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(243, 20);
            this.txtNombreCarrera.TabIndex = 3;
            this.txtNombreCarrera.TextChanged += new System.EventHandler(this.txtNombreCarrera_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Materia";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(173, 131);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(167, 21);
            this.cboMateria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Año de Cursado";
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(173, 175);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(167, 20);
            this.txtAnioCursado.TabIndex = 7;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(293, 213);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(163, 30);
            this.btnAgregarDetalle.TabIndex = 10;
            this.btnAgregarDetalle.Text = "Agregar Detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // rbnPrimerCuatrimestre
            // 
            this.rbnPrimerCuatrimestre.AutoSize = true;
            this.rbnPrimerCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPrimerCuatrimestre.Location = new System.Drawing.Point(434, 129);
            this.rbnPrimerCuatrimestre.Name = "rbnPrimerCuatrimestre";
            this.rbnPrimerCuatrimestre.Size = new System.Drawing.Size(151, 21);
            this.rbnPrimerCuatrimestre.TabIndex = 11;
            this.rbnPrimerCuatrimestre.TabStop = true;
            this.rbnPrimerCuatrimestre.Text = "Primer Cuatrimestre";
            this.rbnPrimerCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbnSegundoCuatrimestre
            // 
            this.rbnSegundoCuatrimestre.AutoSize = true;
            this.rbnSegundoCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSegundoCuatrimestre.Location = new System.Drawing.Point(434, 177);
            this.rbnSegundoCuatrimestre.Name = "rbnSegundoCuatrimestre";
            this.rbnSegundoCuatrimestre.Size = new System.Drawing.Size(158, 20);
            this.rbnSegundoCuatrimestre.TabIndex = 12;
            this.rbnSegundoCuatrimestre.TabStop = true;
            this.rbnSegundoCuatrimestre.Text = "Segundo Cuatrimestre";
            this.rbnSegundoCuatrimestre.UseVisualStyleBackColor = true;
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
            this.Cuatrimestre});
            this.dgvDetalles.Location = new System.Drawing.Point(66, 261);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(662, 131);
            this.dgvDetalles.TabIndex = 13;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(196, 408);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 30);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(422, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 30);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datos de la materia";
            // 
            // carrerasBD_LocalDataSet
            // 
            this.carrerasBD_LocalDataSet.DataSetName = "CarrerasBD_LocalDataSet";
            this.carrerasBD_LocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasBDLocalDataSetBindingSource
            // 
            this.carrerasBDLocalDataSetBindingSource.DataSource = this.carrerasBD_LocalDataSet;
            this.carrerasBDLocalDataSetBindingSource.Position = 0;
            // 
            // IdAsignatura
            // 
            this.IdAsignatura.HeaderText = "Id Asignatura";
            this.IdAsignatura.Name = "IdAsignatura";
            this.IdAsignatura.ReadOnly = true;
            // 
            // NombreAsignatura
            // 
            this.NombreAsignatura.HeaderText = "Nombre Asignatura";
            this.NombreAsignatura.Name = "NombreAsignatura";
            this.NombreAsignatura.ReadOnly = true;
            // 
            // AnioCursado
            // 
            this.AnioCursado.HeaderText = "Año cursado";
            this.AnioCursado.Name = "AnioCursado";
            this.AnioCursado.ReadOnly = true;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            // 
            // frmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.rbnSegundoCuatrimestre);
            this.Controls.Add(this.rbnPrimerCuatrimestre);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Name = "frmNuevaCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aregar Nueva Carrera";
            this.Load += new System.EventHandler(this.frmNuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBD_LocalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBDLocalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.RadioButton rbnSegundoCuatrimestre;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbnPrimerCuatrimestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource carrerasBDLocalDataSetBindingSource;
        private CarrerasBD_LocalDataSet carrerasBD_LocalDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
    }
}