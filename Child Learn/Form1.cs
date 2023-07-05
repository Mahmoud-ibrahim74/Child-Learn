using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child_Learn
{
    public partial class مرحبا : Form
    {
        public مرحبا()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("  (^____^) من فضلك ادخل الاسم  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("مرحبــــا بك يا" +  "  " + name.Text);
                new menu().Show();
                this.Hide();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
