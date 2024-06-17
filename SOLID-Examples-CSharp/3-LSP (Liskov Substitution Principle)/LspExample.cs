namespace SOLID_Examples_CSharp._3_LSP
{
    public class LspExample
    {
        // A classe base Bird define um método virtual Fly
        public class Bird
        {
            public virtual void Fly()
            {
                // Código para a ação de voar
            }
        }

        // A classe Sparrow herda de Bird e pode voar
        public class Sparrow : Bird
        {
            public override void Fly()
            {
                // Código específico para o pardal voar
            }
        }

        // A classe Ostrich herda de Bird, mas não pode voar
        public class Ostrich : Bird
        {
            public override void Fly()
            {
                // Exceção lançada porque avestruzes não voam
                throw new NotSupportedException("Ostrich can't fly.");
            }
        }
    }
}
