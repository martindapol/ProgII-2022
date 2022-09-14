namespace PilasColasApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lstElemento = new System.Windows.Forms.ListBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnVacia = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(29, 28);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(215, 23);
            this.txtElemento.TabIndex = 1;
            // 
            // lstElemento
            // 
            this.lstElemento.FormattingEnabled = true;
            this.lstElemento.ItemHeight = 15;
            this.lstElemento.Location = new System.Drawing.Point(29, 73);
            this.lstElemento.Name = "lstElemento";
            this.lstElemento.Size = new System.Drawing.Size(296, 199);
            this.lstElemento.TabIndex = 2;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(221, 278);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 3;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnVacia
            // 
            this.btnVacia.Location = new System.Drawing.Point(140, 278);
            this.btnVacia.Name = "btnVacia";
            this.btnVacia.Size = new System.Drawing.Size(75, 23);
            this.btnVacia.TabIndex = 5;
            this.btnVacia.Text = "Vacía?";
            this.btnVacia.UseVisualStyleBackColor = true;
            this.btnVacia.Click += new System.EventHandler(this.btnVacia_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(59, 278);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 4;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 317);
            this.Controls.Add(this.btnVacia);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.lstElemento);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(361, 356);
            this.MinimumSize = new System.Drawing.Size(361, 356);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IColeccion | Pilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtElemento;
        private ListBox lstElemento;
        private Button btnExtraer;
        private Button btnVacia;
        private Button btnPrimero;
    }
}