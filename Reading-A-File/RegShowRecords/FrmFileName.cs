using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegShowRecords
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel?");
            this.Hide();
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }
    }
}