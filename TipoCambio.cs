using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImportadorRemisiones
{
    public partial class frmTipoCambio : Form
    {
        public string NuevoTipoCambio { get; private set; }
        public frmTipoCambio()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;

            // Is Float Number?
            if (e.KeyChar == '.' && text.Length > 0 && !text.Contains("."))
            {
                e.Handled = false;
                return;
            }

            // Is Digit?
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void btnTc_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text;
            this.NuevoTipoCambio = tc;
            // AccessDb.InsertarTc(tc);
            //MySqlDatabase db = new MySqlDatabase();
            //db.InsertarTc(tc);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmTipoCambio_Load(object sender, EventArgs e)
        {

        }
    }
}
