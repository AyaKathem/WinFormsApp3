using Labb3_NET22.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class QuizGame : Form
    {
        private global::Quiz quiz = new global::Quiz();
        private float correctAnswers = 0f;
        private Question newQ;
        private int askedQ = 0;
        public QuizGame()
        {
            InitializeComponent();
            button1.Hide();
            label3.Hide();
            textBox1.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            foreach (var item in quiz.GetLists())
            {
                comboBox1.Items.Add(item);
            }

        }

        private void nextQ()
        {
            label2.ResetText();
            newQ = quiz.GetRandomQuestion();

            if (askedQ == quiz.count())
            {
                label1.Hide();
                textBox1.Hide();
                button1.Hide();
                label3.Hide();

                label5.Text = correctAnswers.ToString() + "/" + quiz.count().ToString();
                float percent = (correctAnswers / quiz.count()) * 100;
                label7.Text = percent.ToString() + "%";

            }
            else
            {
                label1.Text = askedQ + "-Statement: " + newQ.Statement;

                for (int count = 0; count < newQ.Answers.Length; count++)
                {

                    label2.Text += count + "- " + newQ.Answers[count] + "\n";
                }
                askedQ++;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (quiz.validateCorrectAnswer(textBox1.Text) == false)
            {
                return;
            }

            if (Int64.Parse(textBox1.Text) == newQ.CorrectAnswer)
            {
                correctAnswers++;
                label5.Text = correctAnswers.ToString() + "/" + quiz.count().ToString();
                float percent = (correctAnswers / quiz.count()) * 100;
                label7.Text = percent.ToString() + "%";
            }
            nextQ();
            textBox1.Clear();

        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a quiz");
            }
            else
            {
                String selectedItem = comboBox1.SelectedItem.ToString();
                

                quiz = new global::Quiz(selectedItem);
                nextQ();
                comboBox1.Hide();
                button2.Hide();
                label8.Hide();
                textBox1.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label3.Show();
                textBox1.Show();
                button1.Show();
            }



        }


    }
}
