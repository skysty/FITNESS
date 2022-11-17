namespace FITNESS
{
    partial class Registr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr));
            this.button_registr = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_registr
            // 
            this.button_registr.BackColor = System.Drawing.Color.Transparent;
            this.button_registr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_registr.BackgroundImage")));
            this.button_registr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registr.Location = new System.Drawing.Point(210, 466);
            this.button_registr.Name = "button_registr";
            this.button_registr.Size = new System.Drawing.Size(200, 45);
            this.button_registr.TabIndex = 0;
            this.button_registr.Click += new System.EventHandler(this.button_registr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(10, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // textlogin
            // 
            this.textlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textlogin.Font = new System.Drawing.Font("Roboto", 15F);
            this.textlogin.ForeColor = System.Drawing.Color.White;
            this.textlogin.Location = new System.Drawing.Point(154, 249);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(349, 25);
            this.textlogin.TabIndex = 3;
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.Font = new System.Drawing.Font("Roboto", 15F);
            this.textpassword.ForeColor = System.Drawing.Color.White;
            this.textpassword.Location = new System.Drawing.Point(154, 327);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(349, 25);
            this.textpassword.TabIndex = 4;
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_registr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Registr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel button_registr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpassword;
    }
}