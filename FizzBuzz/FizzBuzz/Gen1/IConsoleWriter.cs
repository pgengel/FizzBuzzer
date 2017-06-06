namespace FizzBuzz.Gen1
{
	public interface IConsoleWriter
	{
		void WriteLn(string text, params object[] arg);
		void Write(string format, params object[] arg);
	}
}