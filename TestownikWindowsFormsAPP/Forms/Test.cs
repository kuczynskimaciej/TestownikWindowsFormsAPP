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
            FirstAnswerTextBox.Visible = false;
            SecoundAnswerTextBox.Visible = false;
            ThirdAnswerTextBox.Visible = false;
            FourthAnswerTextBox.Visible = false;

            Random rnd = new Random();
            QuestionParserer questionParser = new QuestionParserer();
            var questions = questionParser.ReadQuestions("Pytania");
            var countOfQuestions = questions.Count();
            var indexOfRndQuestion = rnd.Next(countOfQuestions);
            var randomQuestion = questions[indexOfRndQuestion];
            var countOfAnswers = randomQuestion.Answers.Count();
            randomQuestion.Answers.Shuffle();
            TextBox[] textboxes = new TextBox[] { FirstAnswerTextBox, SecoundAnswerTextBox, ThirdAnswerTextBox, FourthAnswerTextBox, FifthTextBox };
            questionTextBox.Text = randomQuestion.Question;

            for (int numberOfTextBox = 0; numberOfTextBox < countOfAnswers; numberOfTextBox++)
            {
                textboxes[numberOfTextBox].Show();
            }
        }
    }
}