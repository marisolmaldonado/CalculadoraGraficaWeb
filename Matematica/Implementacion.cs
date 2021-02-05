namespace Matematica
{
    public class Implementacion
    {
        public double numeroCentigrado { get; set; }

        public object convert()
        {
            return (numeroCentigrado * (1.8) + (32));
        }
    }
}
