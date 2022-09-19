namespace PilasYColas__App.Presentacion
{
    partial class frmPila
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtElementoPila = new System.Windows.Forms.TextBox();
            this.lstElementosPila = new System.Windows.Forms.ListBox();
            this.btnAgregarElementoPila = new System.Windows.Forms.Button();
            this.btnPrimerElemento = new System.Windows.Forms.Button();
            this.btnEstaVaciaPila = new System.Windows.Forms.Button();
            this.btnExtraerElementoPila = new System.Windows.Forms.Button();
            this.btnProximoEnSalir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manejo de elementos tipo Pila";
            // 
            // txtElementoPila
            // 
            this.txtElementoPila.Location = new System.Drawing.Point(109, 70);
            this.txtElementoPila.Name = "txtElementoPila";
            this.txtElementoPila.Size = new System.Drawing.Size(258, 23);
            this.txtElementoPila.TabIndex = 1;
            // 
            // lstElementosPila
            // 
            this.lstElementosPila.FormattingEnabled = true;
            this.lstElementosPila.ItemHeight = 15;
            this.lstElementosPila.Location = new System.Drawing.Point(111, 123);
            this.lstElementosPila.Name = "lstElementosPila";
            this.lstElementosPila.Size = new System.Drawing.Size(256, 304);
            this.lstElementosPila.TabIndex = 2;
            // 
            // btnAgregarElementoPila
            // 
            this.btnAgregarElementoPila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarElementoPila.Location = new System.Drawing.Point(373, 64);
            this.btnAgregarElementoPila.Name = "btnAgregarElementoPila";
            this.btnAgregarElementoPila.Size = new System.Drawing.Size(133, 32);
            this.btnAgregarElementoPila.TabIndex = 3;
            this.btnAgregarElementoPila.Text = "Agregar Elemento";
            this.btnAgregarElementoPila.UseVisualStyleBackColor = false;
            this.btnAgregarElementoPila.Click += new System.EventHandler(this.btnAgregarElementoPila_Click);
            // 
            // btnPrimerElemento
            // 
            this.btnPrimerElemento.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPrimerElemento.Location = new System.Drawing.Point(443, 151);
            this.btnPrimerElemento.Name = "btnPrimerElemento";
            this.btnPrimerElemento.Size = new System.Drawing.Size(133, 32);
            this.btnPrimerElemento.TabIndex = 4;
            this.btnPrimerElemento.Text = "Primer Elemento";
            this.btnPrimerElemento.UseVisualStyleBackColor = false;
            this.btnPrimerElemento.Click += new System.EventHandler(this.btnPrimerElemento_Click);
            // 
            // btnEstaVaciaPila
            // 
            this.btnEstaVaciaPila.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEstaVaciaPila.Location = new System.Drawing.Point(443, 207);
            this.btnEstaVaciaPila.Name = "btnEstaVaciaPila";
            this.btnEstaVaciaPila.Size = new System.Drawing.Size(133, 32);
            this.btnEstaVaciaPila.TabIndex = 5;
            this.btnEstaVaciaPila.Text = "Estado de Pila";
            this.btnEstaVaciaPila.UseVisualStyleBackColor = false;
            this.btnEstaVaciaPila.Click += new System.EventHandler(this.btnEstaVaciaPila_Click);
            // 
            // btnExtraerElementoPila
            // 
            this.btnExtraerElementoPila.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnExtraerElementoPila.Location = new System.Drawing.Point(443, 264);
            this.btnExtraerElementoPila.Name = "btnExtraerElementoPila";
            this.btnExtraerElementoPila.Size = new System.Drawing.Size(133, 32);
            this.btnExtraerElementoPila.TabIndex = 6;
            this.btnExtraerElementoPila.Text = "Extraer Elemento";
            this.btnExtraerElementoPila.UseVisualStyleBackColor = false;
            this.btnExtraerElementoPila.Click += new System.EventHandler(this.btnExtraerElementoPila_Click);
            // 
            // btnProximoEnSalir
            // 
            this.btnProximoEnSalir.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnProximoEnSalir.Location = new System.Drawing.Point(443, 321);
            this.btnProximoEnSalir.Name = "btnProximoEnSalir";
            this.btnProximoEnSalir.Size = new System.Drawing.Size(133, 32);
            this.btnProximoEnSalir.TabIndex = 7;
            this.btnProximoEnSalir.Text = "Próximo en Salir";
            this.btnProximoEnSalir.UseVisualStyleBackColor = false;
            this.btnProximoEnSalir.Click += new System.EventHandler(this.btnProximoEnSalir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(638, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProximoEnSalir);
            this.Controls.Add(this.btnExtraerElementoPila);
            this.Controls.Add(this.btnEstaVaciaPila);
            this.Controls.Add(this.btnPrimerElemento);
            this.Controls.Add(this.btnAgregarElementoPila);
            this.Controls.Add(this.lstElementosPila);
            this.Controls.Add(this.txtElementoPila);
            this.Controls.Add(this.label1);
            this.Name = "frmPila";
            this.Text = "frmPila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtElementoPila;
        private ListBox lstElementosPila;
        private Button btnAgregarElementoPila;
        private Button btnPrimerElemento;
        private Button btnEstaVaciaPila;
        private Button btnExtraerElementoPila;
        private Button btnProximoEnSalir;
        private Button btnSalir;
    }
}