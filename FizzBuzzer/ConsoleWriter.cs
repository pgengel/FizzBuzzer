using System;

namespace ConsoleWriter
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
        public readonly IConsoleWriter consoleWriter;
        readonly string _format;
        readonly object[] _args;

        public Writer(IConsoleWriter consoleWriter, string format, object[] args)
        {
            this.consoleWriter = consoleWriter;
            _format = format;
            _args = args;
        }

        public Writer()
        {
        }

        public void ConsoleWrite(IConsoleWriter consoleWriter)
        {
            consoleWriter.WriteLine(_format, _args);
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
