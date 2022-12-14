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
    public partial class Calendar4 : Form
    {

        private SqlConnection SqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;

        public Calendar4()
        {
            InitializeComponent();
        }

        private void Calendar4_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nurramazan\Documents\Календарь.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM [Table]", SqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Понедельник LIKE '%{textBox1.Text}%'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Page f3 = new Home_Page();
            this.Hide();
            f3.Show();
        }
    }
}
