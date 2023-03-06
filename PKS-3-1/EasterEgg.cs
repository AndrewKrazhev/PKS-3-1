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
    public partial class EasterEgg : Form
    {
        public EasterEgg()
        {
            InitializeComponent();
        }

        private void EasterEgg_Load(object sender, EventArgs e)
        {
            
        }

        private void EasterEgg_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
