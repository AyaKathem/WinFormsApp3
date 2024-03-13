namespace WinFormsApp3
{
    partial class EditQuiz
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
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(35, 159);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(732, 252);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(283, 53);
            button1.Name = "button1";
            button1.Size = new Size(146, 46);
            button1.TabIndex = 2;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(237, 31);
            label1.TabIndex = 3;
            label1.Text = "Enter Quiz Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 115);
            label2.Name = "label2";
            label2.Size = new Size(496, 31);
            label2.TabIndex = 4;
            label2.Text = "Select the question you want to edit:";
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(129, 452);
            button2.Name = "button2";
            button2.Size = new Size(526, 44);
            button2.TabIndex = 5;
            button2.Text = "Select ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(48, 842);
            label8.Name = "label8";
            label8.Size = new Size(36, 26);
            label8.TabIndex = 28;
            label8.Text = "2-";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(91, 840);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(247, 31);
            textBox6.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(48, 786);
            label7.Name = "label7";
            label7.Size = new Size(31, 26);
            label7.TabIndex = 26;
            label7.Text = "1-";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(91, 784);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(247, 31);
            textBox5.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 731);
            label5.Name = "label5";
            label5.Size = new Size(37, 26);
            label5.TabIndex = 24;
            label5.Text = "0-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(366, 678);
            label3.Name = "label3";
            label3.Size = new Size(387, 26);
            label3.TabIndex = 22;
            label3.Text = "The number of the correct answer:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(468, 726);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 31);
            textBox3.TabIndex = 21;
            // 
            // button3
            // 
            button3.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(508, 784);
            button3.Name = "button3";
            button3.Size = new Size(112, 47);
            button3.TabIndex = 20;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 598);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(684, 31);
            textBox2.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(42, 678);
            label6.Name = "label6";
            label6.Size = new Size(146, 26);
            label6.TabIndex = 18;
            label6.Text = "The answers:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(91, 731);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 31);
            textBox4.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(35, 553);
            label9.Name = "label9";
            label9.Size = new Size(130, 31);
            label9.TabIndex = 16;
            label9.Text = "Quostion:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 33);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // EditQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1050);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "EditQuiz";
            Text = "EditQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label5;
        private Label label3;
        private TextBox textBox3;
        private Button button3;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox4;
        private Label label9;
        private ComboBox comboBox1;
    }
}