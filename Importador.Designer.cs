
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importador));
            this.btnVerRemisiones = new System.Windows.Forms.Button();
            this.btnImportarContpaqi = new System.Windows.Forms.Button();
            this.dgvRemisiones = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnTipoCambio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetInvoices = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.InvoiceFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.InvoiceFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceShipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
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
            // btnGetInvoices
            //
            this.btnGetInvoices.Location = new System.Drawing.Point(400, 52);
            this.btnGetInvoices.Name = "btnGetInvoices";
            this.btnGetInvoices.Size = new System.Drawing.Size(138, 35);
            this.btnGetInvoices.TabIndex = 9;
            this.btnGetInvoices.Text = "Ver Facturas";
            this.btnGetInvoices.UseVisualStyleBackColor = true;
            this.btnGetInvoices.Click += new System.EventHandler(this.btnGetInvoices_Click);
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
            this.dgvRemisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRemisiones.Location = new System.Drawing.Point(3, 3);
            this.dgvRemisiones.Name = "dgvRemisiones";
            this.dgvRemisiones.ReadOnly = true;
            this.dgvRemisiones.RowHeadersWidth = 82;
            this.dgvRemisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemisiones.Size = new System.Drawing.Size(762, 385);
            this.dgvRemisiones.TabIndex = 2;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "oid";
            this.Folio.HeaderText = "Programa";
            this.Folio.MinimumWidth = 10;
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
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
            this.txtTipoCambio.Text = "20";
            this.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 425);
            this.tabControl1.TabIndex = 10;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.dgvRemisiones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ordenes";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.dgvInvoices);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facturas";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // dgvInvoices
            //
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.InvoiceFolio,
                //this.InvoiceFecha,
                this.InvoiceCliente,
                this.InvoiceOrden,
                this.InvoiceShipDate});
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 3);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.Size = new System.Drawing.Size(762, 393);
            this.dgvInvoices.TabIndex = 0;
            //
            // InvoiceFolio
            //
            this.InvoiceFolio.DataPropertyName = "folio";
            this.InvoiceFolio.HeaderText = "Folio";
            this.InvoiceFolio.Name = "InvoiceFolio";
            this.InvoiceFolio.ReadOnly = true;
            //
            // InvoiceFecha
            //
            //this.InvoiceFecha.DataPropertyName = "fecha";
            //this.InvoiceFecha.HeaderText = "Fecha";
            //this.InvoiceFecha.Name = "InvoiceFecha";
            //this.InvoiceFecha.ReadOnly = true;
            //
            // InvoiceCliente
            //
            this.InvoiceCliente.DataPropertyName = "codigo_cliente_PO";
            this.InvoiceCliente.HeaderText = "Cliente";
            this.InvoiceCliente.Name = "InvoiceCliente";
            this.InvoiceCliente.ReadOnly = true;
            //
            // InvoiceOrden
            //
            this.InvoiceOrden.DataPropertyName = "orden";
            this.InvoiceOrden.HeaderText = "Orden";
            this.InvoiceOrden.Name = "InvoiceOrden";
            this.InvoiceOrden.ReadOnly = true;
            //
            // InvoiceShipDate
            //
            this.InvoiceShipDate.DataPropertyName = "shipDate";
            this.InvoiceShipDate.HeaderText = "Fecha de Envio";
            this.InvoiceShipDate.Name = "InvoiceShipDate";
            this.InvoiceShipDate.ReadOnly = true;
            //
            // Importador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGetInvoices);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoCambio);
            this.Controls.Add(this.btnImportarContpaqi);
            this.Controls.Add(this.btnVerRemisiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Importador";
            this.Text = "IMPORTADOR DE ORDENES DE COMPRA v2024.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Importador_FormClosing);
            this.Load += new System.EventHandler(this.Importador_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerRemisiones;
        private System.Windows.Forms.Button btnImportarContpaqi;
        private System.Windows.Forms.DataGridView dgvRemisiones;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnGetInvoices;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceFolio;
        //private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceShipDate;
    }


}