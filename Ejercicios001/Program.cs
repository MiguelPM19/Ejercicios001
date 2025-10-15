namespace Ejercicios001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Persona[] personas = new Persona[total];

            for (int i = 0; i < total; i++)
            {
                personas[i] = new Persona(Console.ReadLine());

            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }
    }
}
