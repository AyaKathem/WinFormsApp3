namespace WinFormsApp3
{
    partial class QuizGame
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(56, 120);
            label1.Name = "label1";
            label1.Size = new Size(62, 37);
            label1.TabIndex = 0;
            label1.Text = "   ";
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(389, 552);
            button1.Name = "button1";
            button1.Size = new Size(71, 48);
            button1.TabIndex = 1;
            button1.Text = "Go!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 235);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("MV Boli", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(67, 553);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 40);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 508);
            label3.Name = "label3";
            label3.Size = new Size(491, 31);
            label3.TabIndex = 4;
            label3.Text = "Enter the number of the correct answer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(56, 625);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 5;
            label4.Text = "Score:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 665);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(56, 707);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 7;
            label6.Text = "Percent:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 748);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(71, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(482, 33);
            comboBox1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(650, 73);
            button2.Name = "button2";
            button2.Size = new Size(121, 39);
            button2.TabIndex = 10;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(78, 27);
            label8.Name = "label8";
            label8.Size = new Size(163, 31);
            label8.TabIndex = 11;
            label8.Text = "Select Quiz:";
            // 
            // QuizGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(878, 844);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "QuizGame";
            Text = "Quiz Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Button button2;
        private Label label8;
    }
}