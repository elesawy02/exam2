using FinalC_Quize.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalC_Quize.models
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public ExamType ExamType { get; set; }
        public Question[] Questions { get; set; }
        public int NumberOfQuestions { get; set; }
        public int TimeOfExam { get; set; }
        public int CurrentIndex { get; set; }

        public Exam(ExamType examType, int numberOfQuestions, int timeOfExam)
        {
            ExamType = examType;
            NumberOfQuestions = numberOfQuestions;
            TimeOfExam = timeOfExam;
            Questions = new Question[numberOfQuestions];
            CurrentIndex = 0;
        }

        public void AddQuestion(Question question)
        {
            if (CurrentIndex < Questions.Length)
            {
                Questions[CurrentIndex++] = question;
            }
            else
            {
                throw new InvalidOperationException("Cannot add more questions. The exam is full.");
            }
        }

        public abstract void ShowExam();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return this.TimeOfExam.CompareTo(other.TimeOfExam);
        }

        public override string ToString()
        {
            return $"Exam Type: {ExamType}, Number of Questions: {NumberOfQuestions}, Time: {TimeOfExam} minutes";
        }
    }


}
