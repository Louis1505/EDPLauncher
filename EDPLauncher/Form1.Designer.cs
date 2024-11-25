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
            button_prod = new Button();
            button_not = new Button();
            button_test = new Button();
            pictureBox1 = new PictureBox();
            label_user = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_prod
            // 
            button_prod.FlatAppearance.BorderSize = 0;
            button_prod.FlatStyle = FlatStyle.Flat;
            button_prod.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_prod.ForeColor = Color.FromArgb(64, 64, 64);
            button_prod.ImageAlign = ContentAlignment.TopCenter;
            button_prod.Location = new Point(12, 137);
            button_prod.Name = "button_prod";
            button_prod.Size = new Size(129, 92);
            button_prod.TabIndex = 0;
            button_prod.Text = "EDP\r\nProduktiv";
            button_prod.UseVisualStyleBackColor = true;
            button_prod.Click += button_prod_Click;
            // 
            // button_not
            // 
            button_not.FlatAppearance.BorderSize = 0;
            button_not.FlatStyle = FlatStyle.Flat;
            button_not.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_not.ForeColor = Color.FromArgb(64, 64, 64);
            button_not.Location = new Point(346, 137);
            button_not.Name = "button_not";
            button_not.Size = new Size(129, 92);
            button_not.TabIndex = 4;
            button_not.Text = "EDP\r\nNot\r\n";
            button_not.UseVisualStyleBackColor = true;
            button_not.Click += button_not_Click;
            // 
            // button_test
            // 
            button_test.FlatAppearance.BorderSize = 0;
            button_test.FlatStyle = FlatStyle.Flat;
            button_test.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_test.ForeColor = Color.FromArgb(64, 64, 64);
            button_test.ImageAlign = ContentAlignment.TopCenter;
            button_test.Location = new Point(179, 137);
            button_test.Name = "button_test";
            button_test.Size = new Size(129, 92);
            button_test.TabIndex = 5;
            button_test.Text = "EDP\r\nTest";
            button_test.UseVisualStyleBackColor = true;
            button_test.Click += button_test_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(37, 108);
            label_user.Name = "label_user";
            label_user.Size = new Size(33, 17);
            label_user.TabIndex = 7;
            label_user.Text = "user";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(488, 241);
            Controls.Add(label_user);
            Controls.Add(pictureBox1);
            Controls.Add(button_test);
            Controls.Add(button_not);
            Controls.Add(button_prod);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EDP Launcher";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_prod;
        private Button button_not;
        private Button button_test;
        private PictureBox pictureBox1;
        private Label label_user;
    }
}