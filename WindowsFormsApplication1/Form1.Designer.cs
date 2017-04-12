namespace WindowsFormsApplication1
{
    partial class Wallstreet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallstreet));
            this.signup_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_btn
            // 
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(100, 370);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(105, 46);
            this.signup_btn.TabIndex = 0;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = true;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(278, 370);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(103, 46);
            this.login_btn.TabIndex = 1;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Wallstreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.signup_btn);
            this.Name = "Wallstreet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

