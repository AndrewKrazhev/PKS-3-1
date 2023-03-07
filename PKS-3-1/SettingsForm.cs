using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKS_3_1
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            NametextBox.Text = Properties.Settings.Default.AppName;
            ConntextBox.Text = Properties.Settings.Default.ConnectionString;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

         private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AppName = NametextBox.Text;
            Properties.Settings.Default.ConnectionString = ConntextBox.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
