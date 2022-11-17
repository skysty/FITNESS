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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome();
            this.Hide();
            f1.Show();
        }

        private void button_registr_Click(object sender, EventArgs e)
        {
            if (textlogin.Text == "" || textpassword.Text == "") MessageBox.Show("Заполните все детали");

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nurramazan\Documents\12.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Table]([Login],[Password])VALUES('" + textlogin.Text + "', '" + textpassword.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Успешно Зарегистрировался!");

            Sign f3 = new Sign();
            this.Hide();
            f3.Show();
        }
    }
}
