using Domain.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
        var pessoa = Identificacao();
        var opcaoMenu = MenuPrincipal();
        switch (opcaoMenu)
        {
            case 1:
                MenuDeposito();
                break;

            case 2:
                MenuSaque();
                break;

            default:
                break;
        }
    }

    private static Pessoa Identificacao()
    {
        var pessoa = new Pessoa();

        Console.WriteLine("Seu número de identificação:");
        pessoa.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome:");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Seu CPF:");
        pessoa.Cpf = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Como posso ajudar {pessoa.Nome}?");

        return pessoa;
    }

    private static int MenuPrincipal()
    {
        Console.WriteLine("1 - Depósito");
        Console.WriteLine("2 - Saque");
        Console.WriteLine("3 - Sair");
        Console.WriteLine("----------");
        Console.WriteLine("Selecione uma opção:");
        if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out int resultado) || resultado < 1 || resultado > 3)
        {
            Console.Clear();
            MenuPrincipal();
        }
        return resultado;
    }

    private static void MenuDeposito()
    {
        Console.WriteLine();
        Console.WriteLine("Depósito");
        Console.ReadKey();
    }

    private static void MenuSaque()
    {
        Console.WriteLine();
        Console.WriteLine("Saque");
        Console.ReadKey();
    }
}