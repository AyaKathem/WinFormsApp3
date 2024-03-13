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

    public partial class AddQuiz : Form
    {
        private List<TextBox> Textlist = new List<TextBox>();
        public AddQuiz()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox5, textBox6 };
            string[] answers = new string[] { textBox2.Text, textBox5.Text, textBox6.Text };

            foreach (TextBox box in textBoxes)
            {
                if (box.Text == "")
                {
                    MessageBox.Show("Please fill all the fields first!");
                    return;
                }
            }

            global::Quiz newQ = new global::Quiz();

            if (newQ.validateCorrectAnswer(textBox3.Text) == false)
            {
                return;
            }

            newQ = new global::Quiz(textBox4.Text);
            newQ.AddQuestion(textBox1.Text, int.Parse(textBox3.Text), answers);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Enter quiz name!");
            }
            else
            {
                button2.Enabled = true;
                textBox4.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
