
namespace Classes;

public class Program
{
    public static void Main()
    {
        var usuario1 = new Usuario();

        usuario1.SetNome(Console.ReadLine());
        usuario1.Email = "JoaoClasRoayle@penis.com";
        usuario1.Senha = "SenhaDificil";

        Console.WriteLine(usuario1.Nome);

    }
}