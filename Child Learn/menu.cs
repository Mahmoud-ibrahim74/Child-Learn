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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            new arabic().Show();
            this.Hide();
        }
    }
}
