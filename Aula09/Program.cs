namespace Aula09
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(" ============= Operadores Logicos =============");
            bool isLogged = false;
            bool hasAdminAcess = false;

            Console.WriteLine("Informações de usuário: "); 
            Console.WriteLine("Usuário logado: " + isLogged);
            Console.WriteLine("Usuário tem acesso de administrador: " + hasAdminAcess);

            Console.WriteLine("\nPermissões");

            //Operador (||) - OU
            if (isLogged || hasAdminAcess)
            {
                Console.WriteLine("Acesso ao sistema concedido");
            }
            else
            {
                Console.WriteLine("Acesso ao sistema negado");
            }


            //Operador (&&) - E
            if (isLogged && hasAdminAcess)
            {
                Console.WriteLine("Acesso ao Painel de administrador concidido");
            }
            else
            {
                Console.WriteLine("Acesso ao Painel de administrador negado");
            }

            //Operador (!) - NÃO
            if (isLogged == false)
            {
                Console.WriteLine("Usuário não esta logado");
            }
            else
            {
                Console.WriteLine("Usuário está logado");
            }

        }
    }
}
