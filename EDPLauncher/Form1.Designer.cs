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
            comboBox_funktion = new ComboBox();
            comboBox_anordnung = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_prod
            // 
            button_prod.FlatAppearance.BorderSize = 0;
            button_prod.FlatStyle = FlatStyle.Flat;
            button_prod.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_prod.ForeColor = Color.FromArgb(64, 64, 64);
            button_prod.ImageAlign = ContentAlignment.TopCenter;
            button_prod.Location = new Point(13, 286);
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
            button_not.Location = new Point(479, 286);
            button_not.Margin = new Padding(3, 4, 3, 4);
            button_not.Name = "button_not";
            button_not.Size = new Size(155, 123);
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
            button_test.Location = new Point(246, 286);
            button_test.Margin = new Padding(3, 4, 3, 4);
            button_test.Name = "button_test";
            button_test.Size = new Size(155, 123);
            button_test.TabIndex = 5;
            button_test.Text = "EDP\r\nTest";
            button_test.UseVisualStyleBackColor = true;
            button_test.Click += button_test_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label_user
            // 
            label_user.BackColor = SystemColors.ButtonShadow;
            label_user.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(51, 124);
            label_user.Name = "label_user";
            label_user.Size = new Size(538, 38);
            label_user.TabIndex = 7;
            label_user.Text = "user";
            label_user.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            btn_close.AutoSize = true;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.ForeColor = Color.Red;
            btn_close.Location = new Point(595, -16);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(64, 76);
            btn_close.TabIndex = 8;
            btn_close.Text = "X";
            btn_close.TextAlign = ContentAlignment.TopCenter;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // comboBox_funktion
            // 
            comboBox_funktion.BackColor = SystemColors.InfoText;
            comboBox_funktion.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox_funktion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_funktion.FlatStyle = FlatStyle.Flat;
            comboBox_funktion.FormattingEnabled = true;
            comboBox_funktion.Items.AddRange(new object[] { "Funktion manuell wählen", "Disponent 1", "Disponent 2", "Lagekarte", "LdF", "FuehrungAss", "Einsatzleiter", "16-01", "16-02" });
            comboBox_funktion.Location = new Point(10, 57);
            comboBox_funktion.Margin = new Padding(3, 4, 3, 4);
            comboBox_funktion.Name = "comboBox_funktion";
            comboBox_funktion.Size = new Size(268, 28);
            comboBox_funktion.TabIndex = 9;
            comboBox_funktion.DrawItem += comboBox1_DrawItem;
            comboBox_funktion.DropDown += comboBox1_DropDown;
            comboBox_funktion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox_funktion.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // comboBox_anordnung
            // 
            comboBox_anordnung.BackColor = SystemColors.InfoText;
            comboBox_anordnung.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox_anordnung.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_anordnung.FlatStyle = FlatStyle.Flat;
            comboBox_anordnung.FormattingEnabled = true;
            comboBox_anordnung.Items.AddRange(new object[] { "Anordnung lokale Lage", "Anordnung Flächenlage" });
            comboBox_anordnung.Location = new Point(284, 57);
            comboBox_anordnung.Margin = new Padding(3, 4, 3, 4);
            comboBox_anordnung.Name = "comboBox_anordnung";
            comboBox_anordnung.Size = new Size(268, 28);
            comboBox_anordnung.TabIndex = 10;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 26);
            label1.Name = "label1";
            label1.Size = new Size(268, 27);
            label1.TabIndex = 11;
            label1.Text = "Funktion manuell wählen";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(284, 26);
            label2.Name = "label2";
            label2.Size = new Size(268, 27);
            label2.TabIndex = 12;
            label2.Text = "Fensteranordnung manuell wählen";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox_anordnung);
            groupBox1.Controls.Add(comboBox_funktion);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(37, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 105);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manuelle Optionen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(646, 420);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
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
        private ComboBox comboBox_funktion;
        private ComboBox comboBox_anordnung;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}