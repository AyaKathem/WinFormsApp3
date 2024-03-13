using Labb3_NET22.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class EditQuiz : Form
    {
        private global::Quiz quiz = new global::Quiz();
        private int selected;
        public EditQuiz()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;

            foreach (var item in quiz.GetLists())
            {
                comboBox1.Items.Add(item);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a quiz");
                button2.Enabled = false;
                button3.Enabled = false;
                return;
            }
            String selectedItem = comboBox1.SelectedItem.ToString();


            quiz = new global::Quiz(selectedItem);
            int num = 0;
            foreach (var item in quiz.LoadQuiz())
            {
                listBox1.Items.Add(num + "- " + item.Statement);
                num++;
            }
            button2.Enabled = true;
            Reset();


        }



        private void button2_Click(object sender, EventArgs e)
        {
            selected = listBox1.SelectedIndex;
            Question toEdit = quiz.LoadQuiz().ElementAt(selected);
            textBox2.Text = toEdit.Statement;
            textBox3.Text = toEdit.CorrectAnswer.ToString();
            TextBox[] answers = new TextBox[] { textBox4, textBox5, textBox6 };
            for (int i = 0; i < toEdit.Answers.Length; i++)
            {

                answers[i].Text = toEdit.Answers[i];


            }
            button3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] answers = new String[] { textBox4.Text, textBox5.Text, textBox6.Text };
            if (quiz.validateCorrectAnswer(textBox3.Text) == false)
            {
                return;
            }
            Question eQuestion = new Question(textBox2.Text, int.Parse(textBox3.Text), answers);

            quiz.EditQuestion(selected, eQuestion);


            Reset();
        }

        private void Reset()
        {
            TextBox[] listOfBoxs = new TextBox[] { textBox4, textBox5, textBox6, textBox2, textBox3 };
            foreach (var textbox in listOfBoxs)
            {

                textbox.Text = "";
            }
            button3.Enabled = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
