namespace Aula07
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("========= Operadores de Atibuição ==========");

            //Incializar a variavel
            int x = 10;
            Console.WriteLine("Valor Inicial da Variavel de x" + x);

            //Operador de Atribuição Simples
            x = 20;
            Console.WriteLine("\nAtribuição Simples (=)");
            Console.WriteLine("Valor Atual da Variavel de x: " + x);

            //Atribução Composta (Incremento)
            x++; // x = x + 1;
            Console.WriteLine("\nAtribução Composta Incremento(x++)");
            Console.WriteLine("Valor Atual da Variavel de x: " + x);

            //Atribuição Composta (+=)
            x += 10;
            Console.WriteLine("\nAtribuição Composta (x += 10)");
            Console.WriteLine("Valor Atual da Variavel de x: " + x);

            //Atribuição Composta (-=)
            x -= 10;
            Console.WriteLine("\nAtribuição Composta (x -= 10)");
            Console.WriteLine("Valor Atual da Variavel de x: " + x);

            //Atribuição Composta (*=)
            x *= 10;
            Console.WriteLine("\nAtribuição Composta (x *= 10)");
            Console.WriteLine("Valor Atual da Variavel de x: " + x);

            //Atribuição Composta (/=)
            x /= 10;
            Console.WriteLine("\nAtribuição Composta (x /= 10)");
            Console.WriteLine("Valor Atual da Variavel de x: " + x);
        }
    }
}
