using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestownikWindowsFormsAPP.Views;

namespace TestownikWindowsFormsAPP
{

    public partial class Test : Form
    {
        readonly Random rnd = new Random();
        private KeyValuePair<string, QuestionDto> _question;
        private List<AnswerDto> Answers { get; set; }
        readonly private Dictionary<string, QuestionDto> _dicionaryOfQuestions = new Dictionary<string, QuestionDto>();
        readonly List<bool> Results = new List<bool>();
        public int WhileFail { get; set; }
        private readonly QuestionParsererService _questionParser = new QuestionParsererService();
        public Test(int count)
        {
            InitializeComponent();
            _dicionaryOfQuestions = _questionParser.ReadQuestions("Pytania");
            foreach (var question in _dicionaryOfQuestions)
            {
                question.Value.CountOfRepetitionsOfQuestion = count;
            }
            leftQuestionsLabel.Text = _dicionaryOfQuestions.Count().ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu openMenuForm = new Menu();
            openMenuForm.Show();
            this.Close();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            nextQuestionButton.Visible = false;
            LoadQuestion();
            UnmarkAnswers();
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
            if (_dicionaryOfQuestions.Count() > 0)
            {
                var countOfQuestions = _dicionaryOfQuestions.Count;
                var indexOfRndQuestion = rnd.Next(countOfQuestions);
                _question = _dicionaryOfQuestions.ElementAt(indexOfRndQuestion);
                _question.Value.Answers.Shuffle();
                questionTextBox.Text = _question.Value.Question;
                Answers = _question.Value.Answers.ToList();
                Answers.Shuffle();
                Button[] buttons = { A_Button, B_Button, C_Button, D_Button };
                for (int x = 0; x < Answers.Count(); x++)
                {
                    buttons[x].Text = Answers[x].Answer;
                }
                countOfRepetitionsOfQuestionLabel.Text = _question.Value.CountOfRepetitionsOfQuestion.ToString();
            }
            else
            {
                CheckFinish();
            }
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
            if (Results.All(x => x)) //bool zawsze przyjmuje wartość true
            {
                ResultLabel.Text = "Dobrze!";
                _dicionaryOfQuestions[_question.Key].CountOfRepetitionsOfQuestion--;
                if (_dicionaryOfQuestions[_question.Key].CountOfRepetitionsOfQuestion < 0)
                {
                    _dicionaryOfQuestions.Remove(_question.Key);
                }
                leftQuestionsLabel.Text = _dicionaryOfQuestions.Count().ToString();
            }
            else
            {
                ResultLabel.Text = "Źle!";
                _dicionaryOfQuestions[_question.Key].CountOfRepetitionsOfQuestion += WhileFail;
            }
        }

        public void CheckFinish() //Metoda wyświetlająca ekran końcowy
        {
            if (_dicionaryOfQuestions.Count() == 0)
            {
                this.Hide();
                Finish openFinishForm = new Finish();
                openFinishForm.Show();
            }
        }

        public void AnswerButtonsActivator(bool check) // Metoda do sprawdzenia i pokazania lub ukrycie przycisku "Sprawdź"
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