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
            btn_close = new Button();
            comboBox1 = new ComboBox();
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
            button_prod.Location = new Point(14, 183);
            button_prod.Margin = new Padding(3, 4, 3, 4);
            button_prod.Name = "button_prod";
            button_prod.Size = new Size(155, 123);
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
            button_not.Location = new Point(395, 183);
            button_not.Margin = new Padding(3, 4, 3, 4);
            button_not.Name = "button_not";
            button_not.Size = new Size(147, 123);
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
            button_test.Location = new Point(205, 183);
            button_test.Margin = new Padding(3, 4, 3, 4);
            button_test.Name = "button_test";
            button_test.Size = new Size(147, 123);
            button_test.TabIndex = 5;
            button_test.Text = "EDP\r\nTest";
            button_test.UseVisualStyleBackColor = true;
            button_test.Click += button_test_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(15, 144);
            label_user.Name = "label_user";
            label_user.Size = new Size(36, 20);
            label_user.TabIndex = 7;
            label_user.Text = "user";
            // 
            // btn_close
            // 
            btn_close.AutoSize = true;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.ForeColor = Color.Red;
            btn_close.Location = new Point(515, -19);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(64, 76);
            btn_close.TabIndex = 8;
            btn_close.Text = "X";
            btn_close.TextAlign = ContentAlignment.TopCenter;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InfoText;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Disponent 1", "Disponent 2", "Lagekarte", "LdF", "FuehrungAss", "Einsatzleiter", "16-01", "16-02" });
            comboBox1.Location = new Point(395, 143);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 9;
            comboBox1.DrawItem += comboBox1_DrawItem;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(558, 321);
            Controls.Add(comboBox1);
            Controls.Add(btn_close);
            Controls.Add(label_user);
            Controls.Add(pictureBox1);
            Controls.Add(button_test);
            Controls.Add(button_not);
            Controls.Add(button_prod);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "EDP Launcher";
            MouseDown += Form1_MouseDown;
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
        private Button btn_close;
        private ComboBox comboBox1;
    }
}