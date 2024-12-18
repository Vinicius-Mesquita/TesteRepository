using System.Security.Cryptography.X509Certificates;

namespace console_app
{
    class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static void tabuada(int numero)
        {
        for(int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(numero + "X" + i + "=" + (numero*i));
            }
        }
    }
}




