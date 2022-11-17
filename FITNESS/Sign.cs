using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FITNESS
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome();
            this.Hide();
            f1.Show();
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            if (textlogin.Text == "" || textpassword.Text == "") MessageBox.Show("Заполните все детали");

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nurramazan\Documents\12.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Table] where Login = '" + textlogin.Text + "' and Password = '" + textpassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Home_Page f4 = new Home_Page();
                this.Hide();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!");
            }
        }
    }
}
