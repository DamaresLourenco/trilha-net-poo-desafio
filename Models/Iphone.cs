using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // iPhone instala aplicativos via App Store (simulado)
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            if (!string.IsNullOrWhiteSpace(nomeAplicativo))
            {
                Console.WriteLine($"[iPhone] Buscando {nomeAplicativo} na App Store do {this.GetType().Name}...");
                Console.WriteLine($"[iPhone] {nomeAplicativo} instalado com sucesso!");
            }
            else
            {
                Console.WriteLine("[iPhone] Nome de aplicativo inválido.");
            }
        }
    }
}
