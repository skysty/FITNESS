using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FITNESS
{
    public partial class Coach2 : Form
    {

        private SqlConnection SqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;

        public Coach2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Page f3 = new Home_Page();
            this.Hide();
            f3.Show();
        }

        private void Coach2_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nurramazan\Documents\Календарь.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM [Table]", SqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
