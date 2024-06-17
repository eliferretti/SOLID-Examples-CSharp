namespace SOLID_Examples_CSharp._4_ISP
{
    public class IspExample
    {
        // Interface que define o método Work
        public interface IWorker
        {
            void Work();
        }

        // Interface que define o método Eat
        public interface IEater
        {
            void Eat();
        }

        // A classe Worker implementa as interfaces IWorker e IEater
        public class Worker : IWorker, IEater
        {
            public void Work()
            {
                // Código para o trabalho
            }

            public void Eat()
            {
                // Código para comer
            }
        }

        // A classe Robot implementa apenas a interface IWorker, pois robôs não comem
        public class Robot : IWorker
        {
            public void Work()
            {
                // Código para o trabalho do robô
            }
        }
    }
}
