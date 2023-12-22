namespace desktop_app
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            saveBtn = new Button();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            secondNameLabel = new Label();
            jobLabel = new Label();
            nameLabel = new Label();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            generPassBtn = new Button();
            numbersCheckBox = new CheckBox();
            specialCharCheckBox = new CheckBox();
            lettersCheckBox = new CheckBox();
            textBox3 = new TextBox();
            howMuchCharLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(saveBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 350);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.SteelBlue;
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(219, 39);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(394, 23);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "Zatwierdź";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(401, 350);
            panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(secondNameLabel);
            groupBox1.Controls.Add(jobLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Location = new Point(27, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kierownik", "Starszy Programista", "Młodszy Programista", "Tester" });
            comboBox1.Location = new Point(192, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 3;
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Location = new Point(24, 119);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new Size(57, 15);
            secondNameLabel.TabIndex = 2;
            secondNameLabel.Text = "Nazwisko";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new Point(24, 168);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new Size(67, 15);
            jobLabel.TabIndex = 1;
            jobLabel.Text = "Stanowisko";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(24, 72);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(30, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Imię";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(399, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(401, 350);
            panel4.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(generPassBtn);
            groupBox2.Controls.Add(numbersCheckBox);
            groupBox2.Controls.Add(specialCharCheckBox);
            groupBox2.Controls.Add(lettersCheckBox);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(howMuchCharLabel);
            groupBox2.Location = new Point(28, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie Hasła";
            // 
            // generPassBtn
            // 
            generPassBtn.BackColor = Color.SteelBlue;
            generPassBtn.ForeColor = Color.White;
            generPassBtn.Location = new Point(103, 242);
            generPassBtn.Name = "generPassBtn";
            generPassBtn.Size = new Size(108, 23);
            generPassBtn.TabIndex = 8;
            generPassBtn.Text = "Generuj hasło";
            generPassBtn.UseVisualStyleBackColor = false;
            generPassBtn.Click += generPassBtn_Click;
            // 
            // numbersCheckBox
            // 
            numbersCheckBox.AutoSize = true;
            numbersCheckBox.Location = new Point(39, 153);
            numbersCheckBox.Name = "numbersCheckBox";
            numbersCheckBox.Size = new Size(54, 19);
            numbersCheckBox.TabIndex = 7;
            numbersCheckBox.Text = "Cyfry";
            numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCharCheckBox
            // 
            specialCharCheckBox.AutoSize = true;
            specialCharCheckBox.Location = new Point(39, 191);
            specialCharCheckBox.Name = "specialCharCheckBox";
            specialCharCheckBox.Size = new Size(107, 19);
            specialCharCheckBox.TabIndex = 6;
            specialCharCheckBox.Text = "Znaki specjalne";
            specialCharCheckBox.UseVisualStyleBackColor = true;
            // 
            // lettersCheckBox
            // 
            lettersCheckBox.AutoSize = true;
            lettersCheckBox.Checked = true;
            lettersCheckBox.CheckState = CheckState.Checked;
            lettersCheckBox.Location = new Point(39, 118);
            lettersCheckBox.Name = "lettersCheckBox";
            lettersCheckBox.Size = new Size(126, 19);
            lettersCheckBox.TabIndex = 5;
            lettersCheckBox.Text = "Małe i wielkie litery";
            lettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 23);
            textBox3.TabIndex = 4;
            // 
            // howMuchCharLabel
            // 
            howMuchCharLabel.AutoSize = true;
            howMuchCharLabel.Location = new Point(39, 75);
            howMuchCharLabel.Name = "howMuchCharLabel";
            howMuchCharLabel.Size = new Size(67, 15);
            howMuchCharLabel.TabIndex = 1;
            howMuchCharLabel.Text = "Ile znaków?";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label secondNameLabel;
        private Label jobLabel;
        private Label nameLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private CheckBox numbersCheckBox;
        private CheckBox specialCharCheckBox;
        private CheckBox lettersCheckBox;
        private TextBox textBox3;
        private Label howMuchCharLabel;
        private Button saveBtn;
        private Button generPassBtn;
    }
}