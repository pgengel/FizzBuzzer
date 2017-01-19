using System;

namespace FizzBuzzer
{


    public interface IWriter
    {
        void ConsoleWrite(IConsoleWriter consoleWrite);
    }

    public interface IConsoleWriter
    {
        void Write(string format, object[] args);
        void WriteLine(string format, object[] args);
    }

    public class Writer : IWriter
    {

        public void ConsoleWrite(IConsoleWriter consoleWriter)
        {
            //_consoleWriter.WriteLine();
        }

    }

    public class ConsoleWriter : IConsoleWriter
    {
        public void Write(string format, object[] args)
        {
            Console.Write(format, args);
        }

        public void WriteLine(string format, object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
