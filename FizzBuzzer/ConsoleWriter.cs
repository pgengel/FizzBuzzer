using System;

namespace ConsoleWriters
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
        private IConsoleWriter _consoleWriter;

        private string _format;
        private object[] _args;

        public Writer(string format, object[] args)
        {
            _format = format;
            _args = args;
        }

        public void ConsoleWrite(IConsoleWriter consoleWriter)
        {
            this._consoleWriter = consoleWriter;
            this._consoleWriter.WriteLine(_format, _args);
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
