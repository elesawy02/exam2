using FinalC_Quize.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalC_Quize.models
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int numberOfQuestions, int timeOfExam) : base(ExamType.Practical, numberOfQuestions, timeOfExam) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            foreach (var question in Questions)
            {
                if (question != null)
                {
                    Console.WriteLine($"Header: {question.Header}, Body: {question.Body}, Mark: {question.Mark}");
                    foreach (var answer in question.AnswerList)
                    {
                        Console.WriteLine(answer);
                    }
                    Console.WriteLine($"Correct Answer ID: {question.RightAnswerId}");
                }
            }
        }
    }

}
