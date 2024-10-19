
namespace ImportadorRemisiones
{
    partial class Importador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVerRemisiones = new System.Windows.Forms.Button();
            this.btnImportarContpaqi = new System.Windows.Forms.Button();
            this.dgvRemisiones = new System.Windows.Forms.DataGridView();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.cmbTipoFactura = new System.Windows.Forms.ComboBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnTipoCambio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemisiones)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerRemisiones
            // 
            this.btnVerRemisiones.Location = new System.Drawing.Point(12, 52);
            this.btnVerRemisiones.Name = "btnVerRemisiones";
            this.btnVerRemisiones.Size = new System.Drawing.Size(138, 35);
            this.btnVerRemisiones.TabIndex = 0;
            this.btnVerRemisiones.Text = "Ver Ordenes";
            this.btnVerRemisiones.UseVisualStyleBackColor = true;
            this.btnVerRemisiones.Click += new System.EventHandler(this.btnVerRemisiones_ClickAsync);
            // 
            // btnImportarContpaqi
            // 
            this.btnImportarContpaqi.Location = new System.Drawing.Point(659, 52);
            this.btnImportarContpaqi.Name = "btnImportarContpaqi";
            this.btnImportarContpaqi.Size = new System.Drawing.Size(129, 35);
            this.btnImportarContpaqi.TabIndex = 1;
            this.btnImportarContpaqi.Text = "Exportar Contpaqi";
            this.btnImportarContpaqi.UseVisualStyleBackColor = true;
            this.btnImportarContpaqi.Click += new System.EventHandler(this.btnImportarContpaqi_ClickAsync);
            // 
            // dgvRemisiones
            // 
            this.dgvRemisiones.AllowUserToAddRows = false;
            this.dgvRemisiones.AllowUserToDeleteRows = false;
            this.dgvRemisiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemisiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRemisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.nocliente,
            this.RID,
            this.aproveedor});
            this.dgvRemisiones.Location = new System.Drawing.Point(12, 101);
            this.dgvRemisiones.Name = "dgvRemisiones";
            this.dgvRemisiones.ReadOnly = true;
            this.dgvRemisiones.RowHeadersWidth = 82;
            this.dgvRemisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemisiones.Size = new System.Drawing.Size(776, 417);
            this.dgvRemisiones.TabIndex = 2;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "ofechacreacion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaCreacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaCreacion.HeaderText = "Fecha Creación";
            this.FechaCreacion.MinimumWidth = 10;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 150;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(280, 60);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCambio.TabIndex = 3;
            this.txtTipoCambio.Text = "1";
            this.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipoCambio.TextChanged += new System.EventHandler(this.txtTipoCambio_TextChanged);
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(404, 60);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(244, 21);
            this.cmbTipoFactura.TabIndex = 4;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.Location = new System.Drawing.Point(0, 0);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPago.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo Cambio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Factura:";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnTipoCambio,
            this.toolStripSeparator1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 7;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsBtnTipoCambio
            // 
            this.tsBtnTipoCambio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnTipoCambio.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTipoCambio.Image")));
            this.tsBtnTipoCambio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTipoCambio.Name = "tsBtnTipoCambio";
            this.tsBtnTipoCambio.Size = new System.Drawing.Size(96, 22);
            this.tsBtnTipoCambio.Text = "Tipo de Cambio";
            this.tsBtnTipoCambio.ToolTipText = "tsBtnTipoCambio";
            this.tsBtnTipoCambio.Click += new System.EventHandler(this.tsBtnTipoCambio_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seleccionar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.select_all);
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "oid";
            this.Folio.HeaderText = "Folio";
            this.Folio.MinimumWidth = 10;
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Width = 50;
            // 
            // nocliente
            // 
            this.nocliente.DataPropertyName = "ofechaorden";
            this.nocliente.HeaderText = "Fecha orden";
            this.nocliente.MinimumWidth = 10;
            this.nocliente.Name = "nocliente";
            this.nocliente.ReadOnly = true;
            this.nocliente.Width = 150;
            // 
            // RID
            // 
            this.RID.DataPropertyName = "rid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RID.DefaultCellStyle = dataGridViewCellStyle2;
            this.RID.HeaderText = "RID";
            this.RID.MinimumWidth = 10;
            this.RID.Name = "RID";
            this.RID.ReadOnly = true;
            this.RID.Visible = false;
            this.RID.Width = 50;
            // 
            // aproveedor
            // 
            this.aproveedor.DataPropertyName = "aproveedor";
            this.aproveedor.HeaderText = "Proveedor";
            this.aproveedor.MinimumWidth = 10;
            this.aproveedor.Name = "aproveedor";
            this.aproveedor.ReadOnly = true;
            this.aproveedor.Width = 200;
            // 
            // Importador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoFactura);
            this.Controls.Add(this.txtTipoCambio);
            this.Controls.Add(this.dgvRemisiones);
            this.Controls.Add(this.btnImportarContpaqi);
            this.Controls.Add(this.btnVerRemisiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Importador";
            this.Text = "IMPORTADOR DE ORDENES DE COMPRA v2024.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Importador_FormClosing);
            this.Load += new System.EventHandler(this.Importador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemisiones)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerRemisiones;
        private System.Windows.Forms.Button btnImportarContpaqi;
        private System.Windows.Forms.DataGridView dgvRemisiones;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.ComboBox cmbTipoFactura;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsBtnTipoCambio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nocliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RID;
        private System.Windows.Forms.DataGridViewTextBoxColumn aproveedor;
    }
}

