namespace WinFormsApp3
{
    partial class AddQuiz
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 125);
            label1.Name = "label1";
            label1.Size = new Size(278, 31);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Question:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(654, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 250);
            label2.Name = "label2";
            label2.Size = new Size(213, 26);
            label2.TabIndex = 2;
            label2.Text = "Enter the answers:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 301);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 31);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(575, 356);
            button2.Name = "button2";
            button2.Size = new Size(112, 47);
            button2.TabIndex = 5;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(570, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 31);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(401, 250);
            label3.Name = "label3";
            label3.Size = new Size(454, 26);
            label3.TabIndex = 7;
            label3.Text = "Enter the number of the correct answer:";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 303);
            label5.Name = "label5";
            label5.Size = new Size(37, 26);
            label5.TabIndex = 9;
            label5.Text = "0-";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(33, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 25);
            label6.Name = "label6";
            label6.Size = new Size(227, 31);
            label6.TabIndex = 11;
            label6.Text = "Enter quiz name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(46, 358);
            label7.Name = "label7";
            label7.Size = new Size(31, 26);
            label7.TabIndex = 13;
            label7.Text = "1-";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(89, 356);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(199, 31);
            textBox5.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(46, 414);
            label8.Name = "label8";
            label8.Size = new Size(36, 26);
            label8.TabIndex = 15;
            label8.Text = "2-";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(89, 412);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(199, 31);
            textBox6.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(334, 66);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 16;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(205, 67);
            button3.Name = "button3";
            button3.Size = new Size(112, 47);
            button3.TabIndex = 17;
            button3.Text = "Enter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(878, 694);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddQuiz";
            Text = "AddQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Button button1;
        private Button button3;
    }
}