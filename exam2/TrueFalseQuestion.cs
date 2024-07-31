using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalC_Quize.models
{
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string header, string body, int mark, Answer[] answerList, int rightAnswerId, bool correctAnswer)
            : base(header, body, mark, answerList, rightAnswerId)
        {
            CorrectAnswer = correctAnswer;
        }
    }

}
