namespace FizzBuzzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzzerSimple fb = new FizzBuzzerSimple(new ConsoleWriter.ConsoleWriter(), "",);
            QuestionClient questionClient = new QuestionClient(new Q1());
            questionClient.StartQuestions();
        }
    }
}
