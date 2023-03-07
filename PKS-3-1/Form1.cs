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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout _frmAbout;
            _frmAbout = new FormAbout();
            _frmAbout.ShowDialog();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord _addRecord = new AddRecord();
            _addRecord.MdiParent= this;
            _addRecord.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm _settingsForm=new SettingsForm();
            _settingsForm.ShowDialog();
        }

        private void делаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3= new Form3();
            frm3.MdiParent= this;   
            frm3.Show();
        }
    }
}
