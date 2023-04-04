namespace ExercicioStings3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavraimputada = " ";
            string codificar = " ";
            int numerocarac = 0;
            int numero = 0;

            Console.WriteLine("Digite a palavra que você deseja codificar:");
            palavraimputada = Console.ReadLine();

            numerocarac = palavraimputada.Length;

            for (int i = 0; i < numerocarac; i++)
            {
                numero = Convert.ToInt16(palavraimputada[i]) + 3;
                codificar += Convert.ToChar(numero);


            }

            Console.WriteLine(codificar);
            Console.ReadLine();
        }
    }
}