using System;

interface ILogger
{
    void Log(string message);
    void Error(string message);
    void Warn(string message);
}




class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();
        FileWriter fileWriter = new FileWriter();

        ILogger fileLoggerAdapter = new FileLoggerAdapter(fileWriter);

        logger.Log("This is a log message");
        logger.Error("This is an error message");
        logger.Warn("This is a warning message");

        fileLoggerAdapter.Log("This is a log message");
        fileLoggerAdapter.Error("This is an error message");
        fileLoggerAdapter.Warn("This is a warning message");
    }
}
