﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestownikWindowsFormsAPP
{
    public class QuestionDto
    {
        public string Question { get; set; }
        public List<AnswerDto> Answers { get; set; }
    }
}
