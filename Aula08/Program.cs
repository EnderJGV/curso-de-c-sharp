namespace Aula08
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(" ========== Operadores Relacionais ==========\n");
            Console.Write("Digite o primeiro número: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            // Operadores de Igualdade (==)
            if(x == y)
            {
                result = "X e igual a Y";
            }
            else
            {
                result = "X é diferente de Y";
            }

            Console.WriteLine("Operador (==) : " + result);

            // Operadores de Desigualdade (!=)
            if ( x != y)
            {
                result = "X é diferente de Y";
            }
            else
            {
                result = "X e igual a Y";
            }

            Console.WriteLine("Operador (!=) : " + result);

            // Operadores de Maior que (>)
            if (x > y)
            {
                result = "X é maior que Y";
            }
            else
            {
                result = "X não é maior que Y";
            }

            Console.WriteLine("Operador (>) : " + result);

            // Operadores de Menor que (<)
            if (x < y)
            {
                result = "X é menor que Y";
            }
            else
            {
                result = "X não é menor que Y";
            }
            Console.WriteLine("Operador (<) : " + result);

            // Operadores de Maior ou Igual (>=)
            if (x >= y)
            {
                result = "X é maior ou igual a Y";
            }
            else
            {
                result = "X não é maior ou igual a Y";
            }
            Console.WriteLine("Operador (>=) : " + result);

            // Operadores de Menor ou Igual (<=)
            if (x <= y)
            {
                result = "X é menor ou igual a Y";
            }
            else
            {
                result = "X não é menor ou igual a Y";
            }
            Console.WriteLine("Operador (<=) : " + result);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
        }
    }
}
