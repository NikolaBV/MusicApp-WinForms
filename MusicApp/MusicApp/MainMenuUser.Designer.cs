namespace MusicApp
{
    partial class MainMenuUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_UserProfile = new System.Windows.Forms.Button();
            this.btn_UserSongs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Main Menu";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(325, 270);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btn_UserProfile
            // 
            this.btn_UserProfile.Location = new System.Drawing.Point(230, 191);
            this.btn_UserProfile.Name = "btn_UserProfile";
            this.btn_UserProfile.Size = new System.Drawing.Size(105, 47);
            this.btn_UserProfile.TabIndex = 5;
            this.btn_UserProfile.Text = "Profile";
            this.btn_UserProfile.UseVisualStyleBackColor = true;
            // 
            // btn_UserSongs
            // 
            this.btn_UserSongs.Location = new System.Drawing.Point(119, 191);
            this.btn_UserSongs.Name = "btn_UserSongs";
            this.btn_UserSongs.Size = new System.Drawing.Size(105, 47);
            this.btn_UserSongs.TabIndex = 4;
            this.btn_UserSongs.Text = "Songs";
            this.btn_UserSongs.UseVisualStyleBackColor = true;
            // 
            // MainMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_UserProfile);
            this.Controls.Add(this.btn_UserSongs);
            this.Name = "MainMenuUser";
            this.Text = "MainMenuUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_Logout;
        private Button btn_UserProfile;
        private Button btn_UserSongs;
    }
}