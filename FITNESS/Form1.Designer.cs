namespace FITNESS
{
    partial class Welcome
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.topic_about = new System.Windows.Forms.Panel();
            this.topic_news = new System.Windows.Forms.Panel();
            this.topic_contacts = new System.Windows.Forms.Panel();
            this.news = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orange_buy = new System.Windows.Forms.Panel();
            this.contacts = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textgmail = new System.Windows.Forms.TextBox();
            this.textphone = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sign = new System.Windows.Forms.Panel();
            this.sign_in = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.topic_about.SuspendLayout();
            this.topic_news.SuspendLayout();
            this.news.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contacts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topic_about
            // 
            this.topic_about.BackColor = System.Drawing.Color.Transparent;
            this.topic_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topic_about.BackgroundImage")));
            this.topic_about.Controls.Add(this.topic_news);
            this.topic_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topic_about.Location = new System.Drawing.Point(0, 570);
            this.topic_about.Name = "topic_about";
            this.topic_about.Size = new System.Drawing.Size(400, 150);
            this.topic_about.TabIndex = 0;
            this.topic_about.Click += new System.EventHandler(this.topic_about_Click);
            // 
            // topic_news
            // 
            this.topic_news.BackColor = System.Drawing.Color.Transparent;
            this.topic_news.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topic_news.BackgroundImage")));
            this.topic_news.Controls.Add(this.topic_contacts);
            this.topic_news.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topic_news.Location = new System.Drawing.Point(0, 50);
            this.topic_news.Name = "topic_news";
            this.topic_news.Size = new System.Drawing.Size(350, 100);
            this.topic_news.TabIndex = 1;
            this.topic_news.Click += new System.EventHandler(this.topic_news_Click);
            // 
            // topic_contacts
            // 
            this.topic_contacts.BackColor = System.Drawing.Color.Transparent;
            this.topic_contacts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topic_contacts.BackgroundImage")));
            this.topic_contacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topic_contacts.Location = new System.Drawing.Point(0, 50);
            this.topic_contacts.Name = "topic_contacts";
            this.topic_contacts.Size = new System.Drawing.Size(300, 50);
            this.topic_contacts.TabIndex = 2;
            this.topic_contacts.Click += new System.EventHandler(this.topic_contacts_Click);
            // 
            // news
            // 
            this.news.BackColor = System.Drawing.Color.Transparent;
            this.news.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("news.BackgroundImage")));
            this.news.Controls.Add(this.panel1);
            this.news.Location = new System.Drawing.Point(816, 550);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(464, 170);
            this.news.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.orange_buy);
            this.panel1.Location = new System.Drawing.Point(32, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 88);
            this.panel1.TabIndex = 2;
            // 
            // orange_buy
            // 
            this.orange_buy.BackColor = System.Drawing.Color.Transparent;
            this.orange_buy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orange_buy.BackgroundImage")));
            this.orange_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orange_buy.Location = new System.Drawing.Point(198, 23);
            this.orange_buy.Name = "orange_buy";
            this.orange_buy.Size = new System.Drawing.Size(182, 41);
            this.orange_buy.TabIndex = 3;
            this.orange_buy.Click += new System.EventHandler(this.orange_buy_Click);
            // 
            // contacts
            // 
            this.contacts.BackColor = System.Drawing.Color.Transparent;
            this.contacts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contacts.BackgroundImage")));
            this.contacts.Controls.Add(this.panel2);
            this.contacts.Location = new System.Drawing.Point(816, 405);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(464, 315);
            this.contacts.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.textgmail);
            this.panel2.Controls.Add(this.textphone);
            this.panel2.Controls.Add(this.textname);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(15, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 248);
            this.panel2.TabIndex = 3;
            // 
            // textgmail
            // 
            this.textgmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.textgmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textgmail.Font = new System.Drawing.Font("Roboto", 10F);
            this.textgmail.ForeColor = System.Drawing.Color.White;
            this.textgmail.Location = new System.Drawing.Point(61, 165);
            this.textgmail.Name = "textgmail";
            this.textgmail.Size = new System.Drawing.Size(337, 17);
            this.textgmail.TabIndex = 7;
            // 
            // textphone
            // 
            this.textphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.textphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textphone.Font = new System.Drawing.Font("Roboto", 10F);
            this.textphone.ForeColor = System.Drawing.Color.White;
            this.textphone.Location = new System.Drawing.Point(62, 119);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(337, 17);
            this.textphone.TabIndex = 6;
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(71)))), ((int)(((byte)(72)))));
            this.textname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textname.Font = new System.Drawing.Font("Roboto", 10F);
            this.textname.ForeColor = System.Drawing.Color.White;
            this.textname.Location = new System.Drawing.Point(61, 75);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(337, 17);
            this.textname.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(127, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 30);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.Transparent;
            this.sign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sign.BackgroundImage")));
            this.sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign.Location = new System.Drawing.Point(1115, 25);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(115, 30);
            this.sign.TabIndex = 3;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // sign_in
            // 
            this.sign_in.AutoSize = true;
            this.sign_in.BackColor = System.Drawing.Color.Transparent;
            this.sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_in.ForeColor = System.Drawing.Color.White;
            this.sign_in.Location = new System.Drawing.Point(1002, 31);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(105, 19);
            this.sign_in.TabIndex = 4;
            this.sign_in.Text = "Регистрация";
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(10, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 5;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.news);
            this.Controls.Add(this.topic_about);
            this.Controls.Add(this.contacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topic_about.ResumeLayout(false);
            this.topic_news.ResumeLayout(false);
            this.news.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contacts.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topic_about;
        private System.Windows.Forms.Panel topic_news;
        private System.Windows.Forms.Panel topic_contacts;
        private System.Windows.Forms.Panel news;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel orange_buy;
        private System.Windows.Forms.Panel contacts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel sign;
        private System.Windows.Forms.Label sign_in;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textgmail;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Panel panel4;
    }
}

