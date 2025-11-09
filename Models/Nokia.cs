using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Nokia instala aplicativos via arquivo .apk (simulado)
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            if (!string.IsNullOrWhiteSpace(nomeAplicativo))
            {
                Console.WriteLine($"[Nokia] Instalando {nomeAplicativo} via pacote (.apk) no {this.GetType().Name}...");
                Console.WriteLine($"[Nokia] {nomeAplicativo} instalado com sucesso!");
            }
            else
            {
                Console.WriteLine("[Nokia] Nome de aplicativo inválido.");
            }
        }
    }
}
