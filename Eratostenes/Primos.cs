using System.Collections.Generic;
using System.Linq;

namespace Eratostenes
{    
    class Primos
    {
        internal static List<Numeros> CrearLista(int tamano)
        {
            List<Numeros> listaNumeros = new List<Numeros>();
            for (int i = 0; i < tamano - 1; i++)
			{
                listaNumeros.Add(new Numeros(i + 2, true));
            }
            return listaNumeros;
        }

        internal static List<Numeros> MarcarMultiplos(List<Numeros> listaNumeros)
        {
            foreach (var item in listaNumeros)
            {
                for (int i = item.Numero - 1; i < listaNumeros.Count; i++)
                {
                    listaNumeros[i].EsMultiplo(item.Numero);
                }
            }
            return listaNumeros;
        }

        internal static List<Numeros> EliminarMultiplos(List<Numeros> listaNumeros)
        {
            return listaNumeros.Select(x => x).Where(y => y.EsPrimo).ToList<Numeros>();
        }
    }
}
