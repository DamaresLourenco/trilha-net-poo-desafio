using System;
using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var nokia = new Nokia("11987654321", "Nokia 3310", "11122233344", 64);
        var iphone = new Iphone("11912345678", "iPhone 12", "99988877766", 128);

        Console.WriteLine("=== Teste de Smartphones ===");
        Console.WriteLine(nokia);
        Console.WriteLine(iphone);

        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine(nokia);

        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
        iphone.InstalarAplicativo("Spotify");
        Console.WriteLine(iphone);

        nokia.Desligar();
        iphone.Desligar();

        Console.WriteLine("\nTeste finalizado. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
