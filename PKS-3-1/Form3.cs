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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void delaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.delaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arhiveDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arhiveDataSet.Dela". При необходимости она может быть перемещена или удалена.
            this.delaTableAdapter.Fill(this.arhiveDataSet.Dela);

        }
    }
}
