namespace WinFormsApp3
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuizGame f2 = new QuizGame();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddQuiz f3 = new AddQuiz();


            /* */


            f3.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditQuiz f4 = new EditQuiz();
            f4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}