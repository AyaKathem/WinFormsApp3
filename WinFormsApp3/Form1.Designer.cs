namespace WinFormsApp3
{
    partial class Quiz
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(477, 126);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(376, 78);
            button1.TabIndex = 0;
            button1.Text = "Start Quiz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(477, 417);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(376, 74);
            button2.TabIndex = 1;
            button2.Text = "Create New Quiz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MV Boli", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(477, 269);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(376, 74);
            button3.TabIndex = 2;
            button3.Text = "Edit Quiz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Font = new Font("MV Boli", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaption;
            button6.Location = new Point(517, 27);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(139, 53);
            button6.TabIndex = 5;
            button6.Text = "Login";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("MV Boli", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaption;
            button4.Location = new Point(698, 27);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(139, 53);
            button4.TabIndex = 6;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(304, 31);
            label1.TabIndex = 7;
            label1.Text = "Welcome to Quiz Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 518);
            label2.Name = "label2";
            label2.Size = new Size(541, 31);
            label2.TabIndex = 8;
            label2.Text = "This Program is developed by Aya Kathem";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 115);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(878, 558);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Quiz";
            Text = "Quiz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}