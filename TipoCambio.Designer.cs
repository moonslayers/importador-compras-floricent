namespace ImportadorRemisiones
{
    partial class frmTipoCambio
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
            this.labelTc = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnTc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(13, 9);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(172, 13);
            this.labelTc.TabIndex = 0;
            this.labelTc.Text = "Ingresar el Tipo de Cambio del día:";
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTc.Location = new System.Drawing.Point(12, 30);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(186, 23);
            this.txtTc.TabIndex = 1;
            this.txtTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnTc
            // 
            this.btnTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTc.Location = new System.Drawing.Point(204, 25);
            this.btnTc.Name = "btnTc";
            this.btnTc.Size = new System.Drawing.Size(90, 32);
            this.btnTc.TabIndex = 2;
            this.btnTc.Text = "Guardar";
            this.btnTc.UseVisualStyleBackColor = true;
            this.btnTc.Click += new System.EventHandler(this.btnTc_Click);
            // 
            // frmTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 74);
            this.Controls.Add(this.btnTc);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.labelTc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipoCambio";
            this.ShowIcon = false;
            this.Text = "Tipo de Cambio";
            this.Load += new System.EventHandler(this.frmTipoCambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnTc;
    }
}