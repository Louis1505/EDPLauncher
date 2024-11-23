namespace EDPLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_prod = new System.Windows.Forms.Button();
            this.button_not = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_prod
            // 
            this.button_prod.FlatAppearance.BorderSize = 0;
            this.button_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prod.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_prod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_prod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_prod.Location = new System.Drawing.Point(12, 137);
            this.button_prod.Name = "button_prod";
            this.button_prod.Size = new System.Drawing.Size(129, 92);
            this.button_prod.TabIndex = 0;
            this.button_prod.Text = "EDP\r\nProduktiv";
            this.button_prod.UseVisualStyleBackColor = true;
            this.button_prod.Click += new System.EventHandler(this.button_prod_Click);
            // 
            // button_not
            // 
            this.button_not.FlatAppearance.BorderSize = 0;
            this.button_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_not.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_not.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_not.Location = new System.Drawing.Point(346, 137);
            this.button_not.Name = "button_not";
            this.button_not.Size = new System.Drawing.Size(129, 92);
            this.button_not.TabIndex = 4;
            this.button_not.Text = "EDP\r\nNot\r\n";
            this.button_not.UseVisualStyleBackColor = true;
            this.button_not.Click += new System.EventHandler(this.button_not_Click);
            // 
            // button_test
            // 
            this.button_test.FlatAppearance.BorderSize = 0;
            this.button_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_test.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_test.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_test.Location = new System.Drawing.Point(179, 137);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(129, 92);
            this.button_test.TabIndex = 5;
            this.button_test.Text = "EDP\r\nTest";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(37, 108);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(33, 17);
            this.label_user.TabIndex = 7;
            this.label_user.Text = "user";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(488, 241);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_not);
            this.Controls.Add(this.button_prod);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EDP Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_prod;
        private Button button_not;
        private Button button_test;
        private PictureBox pictureBox1;
        private Label label_user;
    }
}