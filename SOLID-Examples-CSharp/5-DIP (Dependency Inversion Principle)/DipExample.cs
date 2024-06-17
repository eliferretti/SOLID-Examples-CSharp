namespace SOLID_Examples_CSharp._5_DIP
{
    public class DipExample
    {
        // Interface que define o método Log
        public interface ILogger
        {
            void Log(string message);
        }

        // Implementação concreta de ILogger que loga no console
        public class ConsoleLogger : ILogger
        {
            public void Log(string message) => Console.WriteLine(message);
        }

        // A classe Application depende da abstração ILogger, não de uma implementação específica
        public class Application
        {
            private readonly ILogger _logger;

            public Application(ILogger logger)
            {
                _logger = logger; // A dependência é injetada através do construtor
            }

            public void DoWork()
            {
                _logger.Log("Work started.");
                // Código para realizar o trabalho
                _logger.Log("Work finished.");
            }
        }
    }
}
