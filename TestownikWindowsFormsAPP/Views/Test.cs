using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestownikWindowsFormsAPP
{
    public partial class Test : Form
    {
        readonly Random rnd = new Random();
        public List<AnswerDto> Answers { get; set; }
        public int WhileFail { get; set; }
        public int CountOfRepetitons { get; set; }
        private readonly QuestionParsererService questionParser = new QuestionParsererService();
        public Test()
        {
            InitializeComponent();
        }
        public void LoadQuestion()
        {
            var questions = questionParser.ReadQuestions("Pytania");
            foreach (QuestionDto question in questions)
            {
                question.CountOfRepetitionsOfQuestion = CountOfRepetitons;
            }
            var countOfQuestions = questions.Count();
            var indexOfRndQuestion = rnd.Next(countOfQuestions);
            var randomQuestion = questions[indexOfRndQuestion];
            randomQuestion.Answers.Shuffle();
            questionTextBox.Text = randomQuestion.Question;
            Answers = randomQuestion.Answers.ToList();
            Answers.Shuffle();
            A_Button.Text = Answers[0].Answer;
            B_Button.Text = Answers[1].Answer;
            C_Button.Text = Answers[2].Answer;
            D_Button.Text = Answers[3].Answer;
            countOfRepetitionsOfQuestionLabel.Text = randomQuestion.CountOfRepetitionsOfQuestion.ToString();
            UnmarkAnswers();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu openMenuForm = new Menu();
            openMenuForm.Show();
            this.Close();
        }

        private void TossButton_Click(object sender, EventArgs e)
        {
            LoadQuestion();
            //if (CountOfRepetitionsOfQuestion < 0)
            //{
            //    MessageBox.Show("Koniec");
            //}
        }

        private void A_Button_Click(object sender, EventArgs e)
        {
            if (A_Button.BackColor == SystemColors.Control)
            {
                A_Button.BackColor = GetColor(false);
            }
            else if (A_Button.BackColor == Color.LawnGreen)
            {
                A_Button.BackColor = GetColor(true);
            }
        }

        private void B_Button_Click(object sender, EventArgs e)
        {
            if (B_Button.BackColor == SystemColors.Control)
            {
                B_Button.BackColor = GetColor(false);
            }
            else if (B_Button.BackColor == Color.LawnGreen)
            {
                B_Button.BackColor = GetColor(true);
            }
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            if (C_Button.BackColor == SystemColors.Control)
            {
                C_Button.BackColor = GetColor(false);
            }
            else if (C_Button.BackColor == Color.LawnGreen)
            {
                C_Button.BackColor = GetColor(true);
            }
        }

        private void D_Button_Click(object sender, EventArgs e)
        {
            if (D_Button.BackColor == SystemColors.Control)
            {
                D_Button.BackColor = GetColor(false);
            }
            else if (D_Button.BackColor == Color.LawnGreen)
            {
                D_Button.BackColor = GetColor(true);
            }
        }



        public Color GetColor(bool isColored)
        {
            if (isColored)
            {
                return SystemColors.Control;
            }
            else
            {
                return Color.LawnGreen;
            }
        }
        private void UnmarkAnswers()
        {
            A_Button.BackColor = GetColor(true);
            B_Button.BackColor = GetColor(true);
            C_Button.BackColor = GetColor(true);
            D_Button.BackColor = GetColor(true);
        }
    }
}