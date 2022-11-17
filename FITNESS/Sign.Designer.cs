namespace FITNESS
{
    partial class Sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.button_sign = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Panel();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_sign
            // 
            this.button_sign.BackColor = System.Drawing.Color.Transparent;
            this.button_sign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sign.BackgroundImage")));
            this.button_sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sign.Location = new System.Drawing.Point(210, 466);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(200, 45);
            this.button_sign.TabIndex = 0;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(10, 25);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.TabIndex = 1;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textlogin
            // 
            this.textlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.textlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textlogin.ForeColor = System.Drawing.Color.White;
            this.textlogin.Location = new System.Drawing.Point(157, 249);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(349, 23);
            this.textlogin.TabIndex = 2;
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textpassword.ForeColor = System.Drawing.Color.White;
            this.textpassword.Location = new System.Drawing.Point(157, 324);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(349, 23);
            this.textpassword.TabIndex = 3;
            this.textpassword.Visible = false;
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button_sign);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel button_sign;
        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpassword;
    }
}