namespace Login_Form_Application
{
    partial class Login_btn
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
            this.Welcome_lb = new System.Windows.Forms.Label();
            this.User_lb = new System.Windows.Forms.Label();
            this.Password_lb = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_lb
            // 
            this.Welcome_lb.AutoSize = true;
            this.Welcome_lb.Location = new System.Drawing.Point(325, 21);
            this.Welcome_lb.Name = "Welcome_lb";
            this.Welcome_lb.Size = new System.Drawing.Size(95, 25);
            this.Welcome_lb.TabIndex = 0;
            this.Welcome_lb.Text = "Welcome";
            // 
            // User_lb
            // 
            this.User_lb.AutoSize = true;
            this.User_lb.Location = new System.Drawing.Point(64, 78);
            this.User_lb.Name = "User_lb";
            this.User_lb.Size = new System.Drawing.Size(110, 25);
            this.User_lb.TabIndex = 1;
            this.User_lb.Text = "User Name";
            // 
            // Password_lb
            // 
            this.Password_lb.AutoSize = true;
            this.Password_lb.Location = new System.Drawing.Point(64, 125);
            this.Password_lb.Name = "Password_lb";
            this.Password_lb.Size = new System.Drawing.Size(98, 25);
            this.Password_lb.TabIndex = 2;
            this.Password_lb.Text = "Password";
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(216, 78);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(368, 30);
            this.UserName_txt.TabIndex = 3;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(216, 134);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(368, 30);
            this.Password_txt.TabIndex = 4;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(216, 218);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(142, 32);
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(437, 218);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(133, 32);
            this.Loginbtn.TabIndex = 6;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(69, 332);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(142, 32);
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Login_btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Password_lb);
            this.Controls.Add(this.User_lb);
            this.Controls.Add(this.Welcome_lb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login_btn";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_btn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_lb;
        private System.Windows.Forms.Label User_lb;
        private System.Windows.Forms.Label Password_lb;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Exit_btn;
    }
}

