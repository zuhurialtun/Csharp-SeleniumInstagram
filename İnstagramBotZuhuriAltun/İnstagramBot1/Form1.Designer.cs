namespace İnstagramBot1
{
    partial class Form1
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_unfollow = new System.Windows.Forms.ListBox();
            this.lbl_unfollowCount = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.cb_loginAuto = new System.Windows.Forms.CheckBox();
            this.lbl_takipci = new System.Windows.Forms.ListBox();
            this.lbl_takip = new System.Windows.Forms.ListBox();
            this.lbl_followerCount = new System.Windows.Forms.Label();
            this.lbl_followCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(108, 15);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(174, 20);
            this.tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(108, 42);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(174, 20);
            this.tb_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre: ";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(317, 45);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(270, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_unfollow
            // 
            this.lbl_unfollow.FormattingEnabled = true;
            this.lbl_unfollow.Location = new System.Drawing.Point(12, 104);
            this.lbl_unfollow.Name = "lbl_unfollow";
            this.lbl_unfollow.Size = new System.Drawing.Size(270, 342);
            this.lbl_unfollow.TabIndex = 7;
            // 
            // lbl_unfollowCount
            // 
            this.lbl_unfollowCount.AutoSize = true;
            this.lbl_unfollowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_unfollowCount.Location = new System.Drawing.Point(12, 462);
            this.lbl_unfollowCount.Name = "lbl_unfollowCount";
            this.lbl_unfollowCount.Size = new System.Drawing.Size(152, 24);
            this.lbl_unfollowCount.TabIndex = 9;
            this.lbl_unfollowCount.Text = "Takip Etmeyen =";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Location = new System.Drawing.Point(12, 75);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(270, 23);
            this.btn_find.TabIndex = 10;
            this.btn_find.Text = "Takip Etmeyenleri Bul";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // cb_loginAuto
            // 
            this.cb_loginAuto.AutoSize = true;
            this.cb_loginAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_loginAuto.Location = new System.Drawing.Point(317, 15);
            this.cb_loginAuto.Name = "cb_loginAuto";
            this.cb_loginAuto.Size = new System.Drawing.Size(160, 21);
            this.cb_loginAuto.TabIndex = 11;
            this.cb_loginAuto.Text = "Doğrulama İçin Bekle";
            this.cb_loginAuto.UseVisualStyleBackColor = true;
            // 
            // lbl_takipci
            // 
            this.lbl_takipci.FormattingEnabled = true;
            this.lbl_takipci.Location = new System.Drawing.Point(577, 104);
            this.lbl_takipci.Name = "lbl_takipci";
            this.lbl_takipci.Size = new System.Drawing.Size(270, 342);
            this.lbl_takipci.TabIndex = 13;
            // 
            // lbl_takip
            // 
            this.lbl_takip.FormattingEnabled = true;
            this.lbl_takip.Location = new System.Drawing.Point(301, 104);
            this.lbl_takip.Name = "lbl_takip";
            this.lbl_takip.Size = new System.Drawing.Size(270, 342);
            this.lbl_takip.TabIndex = 12;
            // 
            // lbl_followerCount
            // 
            this.lbl_followerCount.AutoSize = true;
            this.lbl_followerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_followerCount.Location = new System.Drawing.Point(573, 462);
            this.lbl_followerCount.Name = "lbl_followerCount";
            this.lbl_followerCount.Size = new System.Drawing.Size(139, 24);
            this.lbl_followerCount.TabIndex = 15;
            this.lbl_followerCount.Text = "Takipçi Sayısı =";
            // 
            // lbl_followCount
            // 
            this.lbl_followCount.AutoSize = true;
            this.lbl_followCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_followCount.Location = new System.Drawing.Point(297, 462);
            this.lbl_followCount.Name = "lbl_followCount";
            this.lbl_followCount.Size = new System.Drawing.Size(125, 24);
            this.lbl_followCount.TabIndex = 14;
            this.lbl_followCount.Text = "Takip Sayısı =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 532);
            this.Controls.Add(this.lbl_takipci);
            this.Controls.Add(this.lbl_takip);
            this.Controls.Add(this.lbl_followerCount);
            this.Controls.Add(this.lbl_followCount);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.lbl_unfollowCount);
            this.Controls.Add(this.lbl_unfollow);
            this.Controls.Add(this.cb_loginAuto);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ListBox lbl_unfollow;
        private System.Windows.Forms.Label lbl_unfollowCount;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.CheckBox cb_loginAuto;
        private System.Windows.Forms.ListBox lbl_takipci;
        private System.Windows.Forms.ListBox lbl_takip;
        private System.Windows.Forms.Label lbl_followerCount;
        private System.Windows.Forms.Label lbl_followCount;
    }
}

