using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITNESS
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            news.Visible = false;
            contacts.Visible = false;
            

        }

        private void topic_news_Click(object sender, EventArgs e)
        {
            news.Visible = true;
            contacts.Visible = false;
        }

        private void topic_contacts_Click(object sender, EventArgs e)
        {
            contacts.Visible = true;
            news.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void sign_Click(object sender, EventArgs e)
        {
            Sign f2 = new Sign();
            this.Hide();
            f2.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (textname.Text.Length > 0 && textphone.Text.Length > 0 && textgmail.Text.Length > 0)
            {
                MessageBox.Show("Отправлено!");

                textname.Clear();
                textphone.Clear();
                textgmail.Clear();
            }
            else
            {
                MessageBox.Show("Заполните все детали", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Registr f3 = new Registr();
            this.Hide();
            f3.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выход", "Cooбщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void orange_buy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Пожалуйста войдите", "Cooбщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Sign f2 = new Sign();
                this.Hide();
                f2.Show();
            }
        }

        private void topic_about_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            this.Hide();
            f1.Show();
        }
    }
}
