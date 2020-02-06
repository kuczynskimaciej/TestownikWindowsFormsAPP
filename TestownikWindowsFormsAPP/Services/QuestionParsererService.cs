﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestownikWindowsFormsAPP
{

    public class QuestionParsererService
    {
        public Dictionary<string, QuestionDto> ReadQuestions(string path)
        {
            string[] questionFiles = Directory.GetFiles(path);
            Dictionary<string, QuestionDto> questions = new Dictionary<string, QuestionDto>();
            foreach (var questionFile in questionFiles)
            {
                string[] lines = File.ReadAllLines(questionFile);
                QuestionDto question = new QuestionDto
                {
                    Question = lines[1]
                };

                var answersPointers = lines[0].ToCharArray();
                var answerLines = lines.Skip(2).ToArray();
                question.Answers = new List<AnswerDto>();
                for (int i = 0; i < answerLines.Length; i++)
                {
                    string answerLine = answerLines[i];
                    string result = answersPointers[i].ToString();
                    var answer = new AnswerDto
                    {
                        Answer = answerLine,
                        IsCorrect = result == "1"
                    };

                    question.Answers.Add(answer);
                }

                questions.Add(questionFile.Substring(questionFile.IndexOf("\\")).Replace("\\", ""), question);
            }

            return questions;
        }
    }
}
