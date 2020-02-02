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
        public List<AnswerDto> Answers { get; set; }
        public int CountOfRepetitionsOfQuestion { get; set; }
        public int WhileFail { get; set; }
        private readonly QuestionParsererService questionParser = new QuestionParsererService();
        public Test()
        {
            InitializeComponent();
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
            if (CountOfRepetitionsOfQuestion < 0)
            {
                MessageBox.Show("Koniec");
            }
        }

        private void A_Button_Click(object sender, EventArgs e)
        {
            if (A_Button.BackColor == SystemColors.Control)
            {
                if (Answers[0].IsCorrect == true)
                {
                    CountOfRepetitionsOfQuestion--;
                }
                A_Button.BackColor = GetColor(false);
            }
            else if (A_Button.BackColor == Color.LawnGreen)
            {
                if (Answers[0].IsCorrect == false)
                {
                    CountOfRepetitionsOfQuestion += WhileFail;
                }
                A_Button.BackColor = GetColor(true);
            }
        }

        private void B_Button_Click(object sender, EventArgs e)
        {
            if (B_Button.BackColor == SystemColors.Control)
            {
                if (Answers[1].IsCorrect == true)
                {
                    CountOfRepetitionsOfQuestion--;
                }
                B_Button.BackColor = GetColor(false);
            }
            else if (B_Button.BackColor == Color.LawnGreen)
            {
                if (Answers[1].IsCorrect == false)
                {
                    CountOfRepetitionsOfQuestion += WhileFail;
                }
                B_Button.BackColor = GetColor(true);
            }
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            if (C_Button.BackColor == SystemColors.Control)
            {
                if (Answers[2].IsCorrect == true)
                {
                    CountOfRepetitionsOfQuestion--;
                }
                C_Button.BackColor = GetColor(false);
            }
            else if (C_Button.BackColor == Color.LawnGreen)
            {
                if (Answers[2].IsCorrect == false)
                {
                    CountOfRepetitionsOfQuestion += WhileFail;
                }
                C_Button.BackColor = GetColor(true);
            }
        }

        private void D_Button_Click(object sender, EventArgs e)
        {
            if (D_Button.BackColor == SystemColors.Control)
            {
                if (Answers[3].IsCorrect == true)
                {
                    CountOfRepetitionsOfQuestion--;
                }
                D_Button.BackColor = GetColor(false);
            }
            else if (D_Button.BackColor == Color.LawnGreen)
            {
                if (Answers[3].IsCorrect == false)
                {
                    CountOfRepetitionsOfQuestion += WhileFail;
                }
                D_Button.BackColor = GetColor(true);
            }
        }

        public void LoadQuestion()
        {
            Random rnd = new Random();

            var questions = questionParser.ReadQuestions("Pytania");
            var countOfQuestions = questions.Count();
            var indexOfRndQuestion = rnd.Next(countOfQuestions);
            var randomQuestion = questions[indexOfRndQuestion];
            randomQuestion.Answers.Shuffle();
            randomQuestion.CountOfRepetitionsOfQuestion = CountOfRepetitionsOfQuestion;
            countOfRepetitionsOfQuestionLabel.Text = CountOfRepetitionsOfQuestion.ToString();
            questionTextBox.Text = randomQuestion.Question;
            Answers = randomQuestion.Answers.ToList();
            Answers.Shuffle();
            A_Button.Text = Answers[0].Answer;
            B_Button.Text = Answers[1].Answer;
            C_Button.Text = Answers[2].Answer;
            D_Button.Text = Answers[3].Answer;
            UnmarkAnswers();
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