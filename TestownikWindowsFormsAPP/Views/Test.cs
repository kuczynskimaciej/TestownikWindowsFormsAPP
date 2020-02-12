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
        private short hours, mins, sec;

        public Test(int count) //Konstruktor
        {
            InitializeComponent();
            _dicionaryOfQuestions = _questionParser.ReadQuestions("Pytania");
            foreach (var question in _dicionaryOfQuestions)
            {
                question.Value.CountOfRepetitionsOfQuestion = count;
            }
            leftQuestionsLabel.Text = _dicionaryOfQuestions.Count().ToString();
            timer1.Start();
            TimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, sec);
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = _dicionaryOfQuestions.Count();
        }
        private void Test_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                backButton.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                checkButton.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                nextQuestionButton.PerformClick();
            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                A_Button.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                B_Button.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                C_Button.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                D_Button.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                E_Button.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                F_Button.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                G_Button.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                H_Button.PerformClick();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jesteś pewny?", "Koniec", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Menu openMenuForm = new Menu();
                openMenuForm.Show();
                this.Close();
            }
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

        private void E_Button_Click(object sender, EventArgs e)
        {
            if (E_Button.BackColor == SystemColors.Control)
            {
                E_Button.BackColor = GetColor(false);
            }
            else if (E_Button.BackColor == Color.CornflowerBlue)
            {
                E_Button.BackColor = GetColor(true);
            }
        }

        private void F_Button_Click(object sender, EventArgs e)
        {
            if (F_Button.BackColor == SystemColors.Control)
            {
                F_Button.BackColor = GetColor(false);
            }
            else if (F_Button.BackColor == Color.CornflowerBlue)
            {
                F_Button.BackColor = GetColor(true);
            }
        }

        private void G_Button_Click(object sender, EventArgs e)
        {
            if (G_Button.BackColor == SystemColors.Control)
            {
                G_Button.BackColor = GetColor(false);
            }
            else if (G_Button.BackColor == Color.CornflowerBlue)
            {
                G_Button.BackColor = GetColor(true);
            }
        }

        private void H_Button_Click(object sender, EventArgs e)
        {
            if (H_Button.BackColor == SystemColors.Control)
            {
                H_Button.BackColor = GetColor(false);
            }
            else if (H_Button.BackColor == Color.CornflowerBlue)
            {
                H_Button.BackColor = GetColor(true);
            }
        }

        public void LoadQuestion() //Metoda do wczytywania pytan i opdowiedzi oraz ich wyświetlania w sposób losowy
        {

            if (_dicionaryOfQuestions.Count() > 0)
            {
                nextQuestionButton.Visible = false;
                var countOfQuestions = _dicionaryOfQuestions.Count;
                var indexOfRndQuestion = rnd.Next(countOfQuestions);
                _question = _dicionaryOfQuestions.ElementAt(indexOfRndQuestion);
                _question.Value.Answers.Shuffle();
                FileNameLabel.Text = _question.Key;
                questionTextBox.Text = _question.Value.Question;
                Answers = _question.Value.Answers.ToList();
                ShowButtons();
                Answers.Shuffle();
                Button[] buttons = { A_Button, B_Button, C_Button, D_Button, E_Button, F_Button, G_Button, H_Button };
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

        private void CheckAnswers(int numberOfAnswers) //Metoda do wpisywania do listy "Results" poprawność odpowiedzi
        {
            Button[] buttons = { A_Button, B_Button, C_Button, D_Button, E_Button, F_Button, G_Button, H_Button };
            for (int x = 0; x < numberOfAnswers; x++)
            {
                if (Answers[x].IsCorrect == true && buttons[x].BackColor == Color.CornflowerBlue)
                {
                    Results.Add(true);
                    buttons[x].BackColor = Color.LightGreen;
                }
                else
                if (Answers[x].IsCorrect == true && buttons[x].BackColor == GetColor(true))
                {
                    Results.Add(false);
                }
                else
                if (Answers[x].IsCorrect == false && buttons[x].BackColor == Color.CornflowerBlue)
                {
                    Results.Add(false);
                }
                else
                if (A_Button.BackColor == GetColor(true) &&
                    B_Button.BackColor == GetColor(true) &&
                    C_Button.BackColor == GetColor(true) &&
                    D_Button.BackColor == GetColor(true) &&
                    E_Button.BackColor == GetColor(true) &&
                    F_Button.BackColor == GetColor(true) &&
                    G_Button.BackColor == GetColor(true) &&
                    H_Button.BackColor == GetColor(true))
                {
                    Results.Add(false);
                }
            }
        }

        private void CountRepetitions() //Metoda do sprawdzania odpowiedzi
        {
            if (Results.All(x => x)) //bool zawsze przyjmuje wartość true
            {
                ResultLabel.Text = "Dobrze!";
                _dicionaryOfQuestions[_question.Key].CountOfRepetitionsOfQuestion--;
                if (_dicionaryOfQuestions[_question.Key].CountOfRepetitionsOfQuestion < 0)
                {
                    _dicionaryOfQuestions.Remove(_question.Key);
                    progressBar.Increment(1);
                }
                leftQuestionsLabel.Text = _dicionaryOfQuestions.Count().ToString();
            }
            else
            {
                ResultLabel.Text = "Źle!";
                _dicionaryOfQuestions[_question.Key].CountOfRepetitionsOfQuestion += WhileFail;
            }
        }

        private void CheckFinish() //Metoda wyświetlająca ekran końcowy oraz przekazująca czas
        {
            if (_dicionaryOfQuestions.Count() == 0)
            {
                timer1.Stop();
                Finish openFinishForm = new Finish();
                openFinishForm.Sec = sec;
                openFinishForm.Mins = mins;
                openFinishForm.Hours = hours;
                this.Hide();
                openFinishForm.Show();
            }
        }

        private void AnswerButtonsActivator(bool check) //Metoda do sprawdzenia i pokazania lub ukrycie przycisku "Sprawdź"
        {
            Button[] buttons = { A_Button, B_Button, C_Button, D_Button, E_Button, F_Button, G_Button, H_Button };

            if (checkButton.Visible == check)
            {
                for (int x = 0; x < buttons.Count(); x++)
                {
                    buttons[x].Enabled = check;
                }
            }
        }

        private Color GetColor(bool isColored) //Metoda do ustawiania koloru przycisku
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

        private void UnmarkAnswers() //Metoda do zerowania kolorów przycisków
        {
            A_Button.BackColor = GetColor(true);
            B_Button.BackColor = GetColor(true);
            C_Button.BackColor = GetColor(true);
            D_Button.BackColor = GetColor(true);
            E_Button.BackColor = GetColor(true);
            F_Button.BackColor = GetColor(true);
            G_Button.BackColor = GetColor(true);
            H_Button.BackColor = GetColor(true);
        }

        private void ShowButtons()
        {
            Button[] buttons = { A_Button, B_Button, C_Button, D_Button, E_Button, F_Button, G_Button, H_Button };
            for (int x = 0; x < buttons.Length; x++)
            {
                buttons[x].Visible = false;
            }

            for (int x = 0; x < Answers.Count; x++)
            {
                buttons[x].Visible = true;
            }
        } //Metoda wyświetlająca odpowiednią ilość Buttonów

        private void TimerTick(object sender, EventArgs e)
        {
            if (sec < 59)
            {
                sec++;
            }
            else
            {
                sec = 0;
                if (mins < 59)
                {
                    mins++;
                }
                else
                {
                    hours++;
                    mins = 0;
                }
            }
            TimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, sec);
        } //Metoda wyświetlająca czas
    }
}