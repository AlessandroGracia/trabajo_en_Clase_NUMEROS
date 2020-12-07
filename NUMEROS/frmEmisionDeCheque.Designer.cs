namespace NUMEROS
{
    partial class frmEmisionDeCheque
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagueseAlaOrdende = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paguese a la orden De :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "La Canridad de:";
            // 
            // txtPagueseAlaOrdende
            // 
            this.txtPagueseAlaOrdende.Location = new System.Drawing.Point(159, 47);
            this.txtPagueseAlaOrdende.Name = "txtPagueseAlaOrdende";
            this.txtPagueseAlaOrdende.Size = new System.Drawing.Size(320, 20);
            this.txtPagueseAlaOrdende.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(119, 84);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(147, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(34, 143);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(478, 93);
            this.txtResultado.TabIndex = 4;
            // 
            // CALCULAR
            // 
            this.CALCULAR.Location = new System.Drawing.Point(419, 87);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(93, 39);
            this.CALCULAR.TabIndex = 5;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // frmEmisionDeCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 287);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPagueseAlaOrdende);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmisionDeCheque";
            this.Text = "frmEmisionDeCheque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPagueseAlaOrdende;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button CALCULAR;
    }
}