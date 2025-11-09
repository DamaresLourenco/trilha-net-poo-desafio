using System;

namespace DesafioPOO.Models
{
    // Classe abstrata que serve de modelo para celulares
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }
        public bool Ligado { get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Ligado = false;
        }

        public void Ligar()
        {
            if (!Ligado)
            {
                Ligado = true;
                Console.WriteLine($"\n{Modelo} ({Numero}) ligado.");
            }
            else
            {
                Console.WriteLine($"\n{Modelo} já está ligado.");
            }
        }

        public void Desligar()
        {
            if (Ligado)
            {
                Ligado = false;
                Console.WriteLine($"\n{Modelo} ({Numero}) desligado.");
            }
            else
            {
                Console.WriteLine($"\n{Modelo} já está desligado.");
            }
        }

        // Método abstrato: cada marca implementa sua forma de instalar apps
        public abstract void InstalarAplicativo(string nomeAplicativo);

        public override string ToString()
        {
            return $"Modelo: {Modelo} | Número: {Numero} | IMEI: {Imei} | Memória: {Memoria}MB | Ligado: {Ligado}";
        }
    }
}
