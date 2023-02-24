namespace MusicApp
{
    partial class MainMenuAdmin
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
            this.btn_AdminSongs = new System.Windows.Forms.Button();
            this.btn_AdminUsers = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AdminSongs
            // 
            this.btn_AdminSongs.Location = new System.Drawing.Point(114, 171);
            this.btn_AdminSongs.Name = "btn_AdminSongs";
            this.btn_AdminSongs.Size = new System.Drawing.Size(105, 47);
            this.btn_AdminSongs.TabIndex = 0;
            this.btn_AdminSongs.Text = "Songs";
            this.btn_AdminSongs.UseVisualStyleBackColor = true;
            // 
            // btn_AdminUsers
            // 
            this.btn_AdminUsers.Location = new System.Drawing.Point(225, 171);
            this.btn_AdminUsers.Name = "btn_AdminUsers";
            this.btn_AdminUsers.Size = new System.Drawing.Size(105, 47);
            this.btn_AdminUsers.TabIndex = 1;
            this.btn_AdminUsers.Text = "Users";
            this.btn_AdminUsers.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(320, 250);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Main Menu";
            // 
            // MainMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_AdminUsers);
            this.Controls.Add(this.btn_AdminSongs);
            this.Name = "MainMenuAdmin";
            this.Text = "MainMenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_AdminSongs;
        private Button btn_AdminUsers;
        private Button btn_Logout;
        private Label label1;
    }
}