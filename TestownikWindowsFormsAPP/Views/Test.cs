using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestownikWindowsFormsAPP
{
    public partial class Test : Form
    {
        readonly Random rnd = new Random();
        public List<QuestionDto> Questions { get; set; }
        public List<AnswerDto> Answers { get; set; }
        readonly List<bool> Results = new List<bool>();
        public int WhileFail { get; set; }
        public int CountOfRepetitons { get; set; }
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

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            LoadQuestion();
            checkButton.Visible = true;
            ResultLabel.Text = "";
            Results.Clear();
            AnswerButtonsActivator(true);
        }


        private void CheckButton_Click(object sender, EventArgs e)
        {
            CheckAnswers(Answers.Count());
            checkButton.Visible = false;
            AnswerButtonsActivator(false);
            nextQuestionButton.Visible = true;
            CountRepetitions();
        }

        private void A_Button_Click(object sender, EventArgs e)
        {
            if (A_Button.BackColor == SystemColors.Control)
            {
                A_Button.BackColor = GetColor(false);
            }
            else if (A_Button.BackColor == Color.CornflowerBlue)
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
            else if (B_Button.BackColor == Color.CornflowerBlue)
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
            else if (C_Button.BackColor == Color.CornflowerBlue)
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
            else if (D_Button.BackColor == Color.CornflowerBlue)
            {
                D_Button.BackColor = GetColor(true);
            }
        }

        public void LoadQuestion() //Metoda do wczytywania pytan i opdowiedzi oraz ich wyświetlania w sposób losowy
        {
            nextQuestionButton.Visible = false;
            Questions = questionParser.ReadQuestions("Pytania");
            foreach (var question in Questions)
            {
                question.CountOfRepetitionsOfQuestion = CountOfRepetitons;
            }

            var countOfQuestions = Questions.Count();
            var indexOfRndQuestion = rnd.Next(countOfQuestions);
            var randomQuestion = Questions[indexOfRndQuestion];
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

        public void CheckAnswers(int numberOfAnswers) // Metoda do wpisywania do listy "Results" poprawność odpowiedzi
        {
            Button[] buttons = { A_Button, B_Button, C_Button, D_Button };
            for (int x = 0; x < numberOfAnswers; x++)
            {
                if (Answers[x].IsCorrect == true && buttons[x].BackColor == Color.CornflowerBlue)
                {
                    Results.Add(true);
                    buttons[x].BackColor = Color.LightGreen;
                }
                else
                if (Answers[x].IsCorrect == false && buttons[x].BackColor == Color.CornflowerBlue)
                {
                    Results.Add(false);
                }
                else
                if (A_Button.BackColor == GetColor(true) && B_Button.BackColor == GetColor(true) && C_Button.BackColor == GetColor(true) && D_Button.BackColor == GetColor(true))
                {
                    Results.Add(false);
                }
            }
        }

        public void CountRepetitions() //Metoda do sprawdzania odpowiedzi
        {
            if (Results.All(x => x == true))
            {
                ResultLabel.Text = "GOOD";
            }
            else
            {
                ResultLabel.Text = "BAAD";
            }
        }

        public void AnswerButtonsActivator(bool check) // Metoda to sprawdzenia i pokazania lub ukrycie przycisku "Sprawdź"
        {
            Button[] buttons = { A_Button, B_Button, C_Button, D_Button };

            if (checkButton.Visible == check)
            {
                for (int x = 0; x < buttons.Count(); x++)
                {
                    buttons[x].Enabled = check;
                }
            }
        }
        public Color GetColor(bool isColored) //Metoda do ustawiania koloru przycisku
        {
            if (isColored)
            {
                return SystemColors.Control;
            }
            else
            {
                return Color.CornflowerBlue;
            }
        }
        private void UnmarkAnswers() // Metoda do zerowania kolorów przycisków
        {
            A_Button.BackColor = GetColor(true);
            B_Button.BackColor = GetColor(true);
            C_Button.BackColor = GetColor(true);
            D_Button.BackColor = GetColor(true);
        }
    }
}