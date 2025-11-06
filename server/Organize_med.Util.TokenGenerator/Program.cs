using System.Security.Cryptography;

internal class Program
{
    static void Main(string[] args)
    {
        var chave = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));

        Console.Write("Chave de 32 bytes: " + chave);

        Console.Read();
    }
}