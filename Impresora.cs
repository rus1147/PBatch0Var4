using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractocaBatch4__Rus
{
	public class Impresora
	{
		internal  void Imprimir(List<string> listaRegistrosFormateada)
		{
			try
			{
				foreach (string r in listaRegistrosFormateada)
				{
					Console.WriteLine(r);
					Console.WriteLine("\n");
				}
			}
			finally
			{
				Console.WriteLine("Fin de la ejecucion");
			}
		}
	}
}
