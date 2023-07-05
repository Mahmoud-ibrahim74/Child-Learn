using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Child_Learn
{
    public partial class baa : Form
    {
        public baa()
        {
            InitializeComponent();
            f_letter.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }


        private void bunifuImageButton2_Click_3(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                   
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = Environment.CurrentDirectory + @"\sound\3.wav";
            player.Play(); 
        }

        private void bunifuCheckbox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("تشغيــــل الصوت التعليمي", bunifuCheckbox1);
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            if(bunifuCheckbox1.Checked)
            {
                player.SoundLocation = Environment.CurrentDirectory + @"\sound\baa.wav";
                player.Play(); 
            }
            else
            {
                player.Stop();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            if(string.IsNullOrEmpty(f_letter.Text))
            {
                MessageBox.Show(" (^____^)  اكتب حرف البــاء اولا للأنتـــقال الي الدرس التالي", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(f_letter.Text != "ب")
            {
                MessageBox.Show(" (^____^)  اكتب حرف البــاء صحيــح مثل (ب) للأنتـــقال الي الدرس التالي", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                player.SoundLocation = Environment.CurrentDirectory + @"\sound\happy.wav";
                player.Play(); 
                MessageBox.Show(" (^____^)    احسنــــت هيا بنا الي الدرس التالي", "تـــم", MessageBoxButtons.OK, MessageBoxIcon.None);
                new taa().Show();
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(f_letter.Visible == false)
            {
                animator1.ShowSync(f_letter);

            }

            
        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("الانتــــقال الي الدرس التالي", bunifuImageButton1);

        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.RemoveAll();
        }
    }
}
