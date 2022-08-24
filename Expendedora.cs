using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        //Atributos
        string marca;
        byte temperatura;
        string codigo; // codigo es un atributo
        float precioF;
        //Constructor 
        public Expendedora()
        {
            Saludar();
            ControlarTiempoDisplay();
            marca = "AMS";
            Console.WriteLine("Marca: " + marca);
            temperatura = 14;
            Console.WriteLine("Temperatura: " + temperatura + " °C");
            ControlarTiempoDisplay();
            codigo = MostrarCodigoDeProductos();
            MostrarPrecio(codigo);
        }
        //Métodos
        void ControlarTiempoDisplay()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }
        void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }
        string MostrarCodigoDeProductos()
        {
            Console.WriteLine("A1: Kinder Delice \tB1: Takis \tC1: Donitas");
            Console.WriteLine("Ingrese el código del producto a elegir:"); 
            string codigo = Console.ReadLine(); //codigo es una variable local porque esta dentro del método
            return codigo;
        }
        void MostrarPrecio(string codigo) //codigo no es la misma variable del otro método
        {
            switch(codigo)
            {
                case "A1":
                    {
                        Console.WriteLine("El precio es: {0}", precioF);
                    }
                     break;
                case "B1":
                    {
                        Console.WriteLine("El precio es: {0}", precioF);
                    }
                    break;
                case "C1":
                    {
                        Console.WriteLine("El precio es: {0}", precioF);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Producto inválido");
                    }
                    break;
            }
        }
    }
}
