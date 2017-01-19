using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzer
{


    public interface IWriter
    {
        string ConsoleWrite(IConsoleWriter consoleWrite);
    }

    public interface IConsoleWriter
    {
        string Write(string format, object[] args);
        string WriteLine(string format, object[] args);
    }

    public class Writer: IWriter
    {

        public string ConsoleWrite(IConsoleWriter _consoleWriter)
        {
            throw new NotImplementedException();
        }

    }

    public class ConsoleWriter : IConsoleWriter
    {
        public string Write(string format, object[] args)
        {
            throw new NotImplementedException();
        }

        public string WriteLine(string format, object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
