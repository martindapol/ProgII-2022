namespace Carreras_SP
{
    partial class frmConsultarCarreras
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDetCarrera = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(217, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(108, 88);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(144, 17);
            this.lblCarreras.TabIndex = 17;
            this.lblCarreras.Text = "Seleccione la Carrera";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(283, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // lblDetCarrera
            // 
            this.lblDetCarrera.AutoSize = true;
            this.lblDetCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetCarrera.Location = new System.Drawing.Point(108, 160);
            this.lblDetCarrera.Name = "lblDetCarrera";
            this.lblDetCarrera.Size = new System.Drawing.Size(146, 17);
            this.lblDetCarrera.TabIndex = 19;
            this.lblDetCarrera.Text = "Detalles de la Carrera";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(111, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(608, 186);
            this.listBox1.TabIndex = 20;
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(68, 31);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(136, 16);
            this.lblNuevaCarrera.TabIndex = 21;
            this.lblNuevaCarrera.Text = "Consultar Carreras";
            // 
            // frmConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDetCarrera);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCarreras);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmConsultarCarreras";
            this.Text = "Consulta de Carreras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDetCarrera;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.Button btnCancelar;
    }
}