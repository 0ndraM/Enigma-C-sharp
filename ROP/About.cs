using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        // zavřít
        private void BtnOkClick(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BAF!!");
        }
    }
}
