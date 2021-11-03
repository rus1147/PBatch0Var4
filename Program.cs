using System;
using System.Collections.Generic;

namespace PractocaBatch4__Rus
{
	class Program
	{
		static void Main(string[] args)
		{
			const int NRO_MAX_ARGS = 2;
			if (args.Length == 0 || args.Length > NRO_MAX_ARGS)
			{
				throw new Exception($"Debe ingresar 1 o 2 parametros: direccion de archivo txt; opcional: formato. Se encontraron {args.Length} parametros");
			}
			if (args.Length == NRO_MAX_ARGS) {

				InputReader lectorInput = new InputReader();
				OutputFormat outputFormat = new OutputFormat();
				Impresora impresora = new Impresora();
				Sorting sorting = new Sorting();
				string inputFilePath = args[0];
				string displayFormat = args[1];

				//string inputFilePath = @"C:\Users\Ruslan\Programacion\PracticaBatch4\PBatch0Var4-master\txt\archivo.txt";
				//string displayFormat = "shortformat";

				List<Registro> listaRegistros = lectorInput.LeerInput(inputFilePath);
				sorting.Ordenamiento(listaRegistros);
				List<string> listaRegistrosFormateada = outputFormat.DarFormatoALista(listaRegistros, displayFormat);
				impresora.Imprimir(listaRegistrosFormateada);

			}
		}
	}
}

