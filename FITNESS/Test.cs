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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
            timer1.Start();
            label1.Visible = false;
            store_count.Visible = false;

            label2.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = ""; label6.Text = ""; label12.Text = "Итого: ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выход", "Cooбщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            h_page.Width += 40;
            if (h_page.Width >= 1110)
            {
                timer1.Stop();
            }
        }

        private void programs_Click(object sender, EventArgs e)
        {
            home.Location = new Point(486, 24);
            programs.Location = new Point(566, 34);
            coach.Location = new Point(646, 24);
            store.Location = new Point(726, 24);
            cheque.Location = new Point(1192, 24);

            timer3.Start();
            
        }

        private void home_Click(object sender, EventArgs e)
        {
            home.Location = new Point(486, 34);
            programs.Location = new Point(566, 24);
            coach.Location = new Point(646, 24);
            store.Location = new Point(726, 24);
            cheque.Location = new Point(1192, 24);

            if (h_page.Width >= 1110) timer4.Start();
            else timer1.Start();
        }

        private void coach_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void coach_Click(object sender, EventArgs e)
        {
            home.Location = new Point(486, 24);
            programs.Location = new Point(566, 24);
            coach.Location = new Point(646, 34);
            store.Location = new Point(726, 24);
            cheque.Location = new Point(1192, 24);

            timer5.Start();
            timer4.Start();
            timer2.Start();
        }

        private void store_Click(object sender, EventArgs e)
        {
            home.Location = new Point(486, 24);
            programs.Location = new Point(566, 24);
            coach.Location = new Point(646, 24);
            store.Location = new Point(726, 34);
            cheque.Location = new Point(1192, 24);

            timer7.Start();
            timer2.Start();
            timer4.Start();
            timer6.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            h_page.Width -= 40;
            if (h_page.Width <= 0)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tarif_page.Width += 40;
            if (tarif_page.Width >= 1110)
            {
                timer3.Stop();
                timer2.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            tarif_page.Width -= 40;
            if (tarif_page.Width <= 0)
            {
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            coach_page.Width += 40;
            if (coach_page.Width >= 1110)
            {
                timer5.Stop();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            coach_page.Width -= 40;
            if (coach_page.Width <= 0)
            {
                timer6.Stop();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            store_page.Width += 40;
            if (store_page.Width >= 1110)
            {
                timer7.Stop();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            store_page.Width -= 40;
            if (store_page.Width <= 0)
            {
                timer8.Stop();
            }
        }

        int count = 0, count1 = 0, protein1 = 0;
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            count = count + 1;
            count1 = count1 + 1;
            label1.Text = count + "";
            protein1 = protein1 + 14990;
            label6.Text = protein4 + protein1 + protein2 + protein3 + "₸";
            label1.Visible = true;
            store_count.Visible = true;

            if ((label2.Text == "") || label2.Text.IndexOf("Протеин Optimum Nutrition") == 0 )
            {
                label2.Text = "Протеин Optimum Nutrition \t\t " + count1 + "\t\t  " + protein1 + "₸";
            }
            else
            {
                if ((label3.Text == "") || label3.Text.IndexOf("Протеин Optimum Nutrition") == 0)
                {
                    label3.Text = "Протеин Optimum Nutrition \t\t " + count1 + "\t\t  " + protein1 + "₸";
                }
                else
                {
                    if ((label4.Text == "") || label4.Text.IndexOf("Протеин Optimum Nutrition") == 0)
                    {
                        label4.Text = "Протеин Optimum Nutrition \t\t " + count1 + "\t\t  " + protein1 + "₸";
                    }
                    else
                    {
                        if ((label5.Text == "") || label5.Text.IndexOf("Протеин Optimum Nutrition") == 0)
                        {
                            label5.Text = "Протеин Optimum Nutrition \t\t " + count1 + "\t\t  " + protein1 + "₸";
                        }
                    }
                }
            }
            
        }

        int protein2 = 0, count2 = 0;
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            count = count + 1;
            count2 = count2 + 1;
            label1.Text = count + "";
            protein2 = protein2 + 22800;
            label6.Text = protein4 + protein1 + protein2 + protein3 + "₸";
            label1.Visible = true;
            store_count.Visible = true;

            if ((label2.Text == "") || label2.Text.IndexOf("Протеин SynTrax Matrix") == 0)
            {
                label2.Text = "Протеин SynTrax Matrix \t\t " + count2 + "\t\t  " + protein2 + "₸";
            }
            else
            {
                if ((label3.Text == "") || label3.Text.IndexOf("Протеин SynTrax Matrix") == 0)
                {
                    label3.Text = "Протеин SynTrax Matrix \t\t " + count2 + "\t\t  " + protein2 + "₸";
                }
                else
                {
                    if ((label4.Text == "") || label4.Text.IndexOf("Протеин SynTrax Matrix") == 0)
                    {
                        label4.Text = "Протеин SynTrax Matrix \t\t " + count2 + "\t\t  " + protein2 + "₸";
                    }
                    else
                    {
                        if ((label5.Text == "") || label5.Text.IndexOf("Протеин SynTrax Matrix") == 0)
                        {
                            label5.Text = "Протеин SynTrax Matrix \t\t " + count2 + "\t\t  " + protein2 + "₸";
                        }
                    }
                }
            }
        }

        int protein3 = 0, count3 = 0;
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            count = count + 1;
            count3 = count3 + 1;
            label1.Text = count + "";
            protein3 = protein3 + 7990;
            label6.Text = protein4 + protein1 + protein2 + protein3 + "₸";
            label1.Visible = true;
            store_count.Visible = true;

            label1.Visible = true;
            store_count.Visible = true;

            if ((label2.Text == "") || label2.Text.IndexOf("Протеин Qazprotein") == 0)
            {
                label2.Text = "Протеин Qazprotein \t\t " + count3 + "\t\t  " + protein3 + "₸";
            }
            else
            {
                if ((label3.Text == "") || label3.Text.IndexOf("Протеин Qazprotein") == 0)
                {
                    label3.Text = "Протеин Qazprotein \t\t " + count3 + "\t\t " + protein3 + "₸";
                }
                else
                {
                    if ((label4.Text == "") || label4.Text.IndexOf("Протеин Qazprotein") == 0)
                    {
                        label4.Text = "Протеин Qazprotein \t\t " + count3 + "\t\t  " + protein3 + "₸";
                    }
                    else
                    {
                        if ((label5.Text == "") || label5.Text.IndexOf("Протеин Qazprotein") == 0)
                        {
                            label5.Text = "Протеин Qazprotein \t\t " + count3 + "\t\t  " + protein3 + "₸";
                        }
                    }
                }
            }
        }

        int protein4 = 0, count4 = 0;
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            count = count + 1;
            count4 = count4 + 1;
            label1.Text = count + "";
            protein4 = protein4 + 8890;
            label6.Text = protein4 + protein1 + protein2 + protein3 + "₸";
            label1.Visible = true;
            store_count.Visible = true;

            if ((label2.Text == "") || label2.Text.IndexOf("Протеин Beyond Protein") == 0)
            {
                label2.Text = "Протеин Beyond Protein \t\t " + count4 + "\t\t  " + protein4 + "₸";
            }
            else
            {
                if ((label3.Text == "") || label3.Text.IndexOf("Протеин Beyond Protein") == 0)
                {
                    label3.Text = "Протеин Beyond Protein \t\t " + count4 + "\t\t  " + protein4 + "₸";
                }
                else
                {
                    if ((label4.Text == "") || label4.Text.IndexOf("Протеин Beyond Protein") == 0)
                    {
                        label4.Text = "Протеин Beyond Protein \t\t " + count4 + "\t\t " + protein4 + "₸";
                    }
                    else
                    {
                        if ((label5.Text == "") || label5.Text.IndexOf("Протеин Beyond Protein") == 0)
                        {
                            label5.Text = "Протеин Beyond Protein \t\t " + count4 + "\t\t  " + protein4 + "₸";
                        }
                    }
                }
            }
        }

        private void buy_yellow_Click(object sender, EventArgs e)
        {
            
        }

        private void buy_red_Click(object sender, EventArgs e)
        {
            
        }

        private void calendar_1_Click(object sender, EventArgs e)
        {
            Calendar1 f5 = new Calendar1();
            this.Hide();
            f5.Show();
        }

        private void calendar_2_Click(object sender, EventArgs e)
        {
            Calendar2 f6 = new Calendar2();
            this.Hide();
            f6.Show();
        }

        private void calendar_3_Click(object sender, EventArgs e)
        {
            Calendar3 f7 = new Calendar3();
            this.Hide();
            f7.Show();
        }

        private void calendar_4_Click(object sender, EventArgs e)
        {
            Calendar4 f8 = new Calendar4();
            this.Hide();
            f8.Show();
        }

        private void coach_1_Click(object sender, EventArgs e)
        {
            Coach1 f1 = new Coach1();
            this.Hide();
            f1.Show();
        }

        private void coach_2_Click(object sender, EventArgs e)
        {
            Coach2 f2 = new Coach2();
            this.Hide();
            f2.Show();
        }

        private void coach_3_Click(object sender, EventArgs e)
        {
            Coach3 f3 = new Coach3();
            this.Hide();
            f3.Show();
        }

        private void coach_4_Click(object sender, EventArgs e)
        {
            Coach4 f4 = new Coach4();
            this.Hide();
            f4.Show();
        }

        private void buy_green_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            home.Location = new Point(486, 24);
            programs.Location = new Point(566, 24);
            coach.Location = new Point(646, 24);
            store.Location = new Point(726, 24);
            cheque.Location = new Point(1192, 32);

            timer2.Start();
            timer4.Start();
            timer6.Start();
            timer8.Start();
            timer9.Start();
        }

        private void cheque_buy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Оформить заказ?", "Оформление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                cheque_buy.ImageLocation = @"C:/Users/Nurramazan/Downloads/Спасибо.png";
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            cheque_page.Width += 40;
            if (cheque_page.Width >= 1110)
            {
                timer9.Stop();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            cheque_page.Width -= 40;
            if (cheque_page.Width <= 0)
            {
                timer10.Stop();
            }
        }
    }
}