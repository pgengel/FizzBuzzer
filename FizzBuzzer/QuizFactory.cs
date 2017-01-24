using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzer
{
    public interface IQuestion
    {
        void ExeQuestion();
    }

    public class Question1 : IQuestion
    {
        public void ExeQuestion()
        {
            FizzBuzzerSimple fb = new FizzBuzzerSimple();
        }
    }
    public class Question2 : IQuestion
    {
        public void ExeQuestion()
        {
            
        }
    }
    public class Question3 : IQuestion
    {
        public void ExeQuestion()
        {
            
        }
    }
    public class Question4 : IQuestion
    {
        public void ExeQuestion()
        {
            
        }
    }

    public interface IQFactory
    {
        IQuestion MakeQuestion();
    }

    public class Q1 : IQFactory
    {
        public IQuestion MakeQuestion()
        {
            return new Question1();
        }
    }

    public class QuestionClient
    {
        private readonly IQuestion _question;

        public QuestionClient(IQFactory qFactory)
        {
            _question = qFactory.MakeQuestion();
        }

        public void StartQuestions()
        {
            _question.ExeQuestion();
        }
    }
}
