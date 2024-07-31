using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalC_Quize.models
{
    public class MCQQuestion : Question
    {
        public string[] Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public MCQQuestion(string header, string body, int mark, Answer[] answerList, int rightAnswerId, string[] choices, int correctAnswerIndex)
            : base(header, body, mark, answerList, rightAnswerId)
        {
            Choices = choices;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }

}
