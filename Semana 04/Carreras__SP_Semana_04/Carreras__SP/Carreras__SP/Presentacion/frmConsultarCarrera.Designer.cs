namespace Carreras__SP.Presentacion
{
    partial class frmConsultarCarrera
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.lblCarrerasListado = new System.Windows.Forms.Label();
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultarCarrera = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Seleccione Carrera:";
            // 
            // cboCarreras
            // 
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(87, 63);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(368, 21);
            this.cboCarreras.TabIndex = 32;
            // 
            // lblCarrerasListado
            // 
            this.lblCarrerasListado.AutoSize = true;
            this.lblCarrerasListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrerasListado.Location = new System.Drawing.Point(22, 63);
            this.lblCarrerasListado.Name = "lblCarrerasListado";
            this.lblCarrerasListado.Size = new System.Drawing.Size(59, 16);
            this.lblCarrerasListado.TabIndex = 31;
            this.lblCarrerasListado.Text = "Carreras";
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.AllowUserToAddRows = false;
            this.dgvCarreras.AllowUserToDeleteRows = false;
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Location = new System.Drawing.Point(87, 113);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.ReadOnly = true;
            this.dgvCarreras.Size = new System.Drawing.Size(495, 267);
            this.dgvCarreras.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(330, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 27);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultarCarrera
            // 
            this.btnConsultarCarrera.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConsultarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCarrera.Location = new System.Drawing.Point(461, 63);
            this.btnConsultarCarrera.Name = "btnConsultarCarrera";
            this.btnConsultarCarrera.Size = new System.Drawing.Size(121, 24);
            this.btnConsultarCarrera.TabIndex = 36;
            this.btnConsultarCarrera.Text = "Seleccionar";
            this.btnConsultarCarrera.UseVisualStyleBackColor = false;
            this.btnConsultarCarrera.Click += new System.EventHandler(this.btnConsultarCarrera_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(206, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 27);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmConsultarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 460);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultarCarrera);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvCarreras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCarreras);
            this.Controls.Add(this.lblCarrerasListado);
            this.Name = "frmConsultarCarrera";
            this.Text = "Consultar Carreras";
            this.Load += new System.EventHandler(this.frmConsultarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCarreras;
        private System.Windows.Forms.Label lblCarrerasListado;
        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultarCarrera;
        private System.Windows.Forms.Button btnEliminar;
    }
}