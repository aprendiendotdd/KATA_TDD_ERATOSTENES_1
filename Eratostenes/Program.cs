using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eratostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("ERROR: Numero de parametro inferior a 1");
                return;
            }

            if (Convert.ToInt32(args[0]) < 2)
            {
                Console.WriteLine("ERROR: Valor inferior a 2");
                return;
            }
           
            foreach (var item in Primos.EliminarMultiplos(Primos.MarcarMultiplos(Primos.CrearLista(Convert.ToInt32(args[0])))))
            {
                Console.WriteLine(item.Numero.ToString());
            }

            Console.ReadLine();
        }
    }
}
