using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractocaBatch4__Rus
{
	public class InputReader
	{	
		List<Registro> ListaDeLineasArchivo= new List<Registro>();
		private const int INPUT_LINE_LENGTH = 25;
		
		 private static Registro ParseoLineaInput(string linea)
		{
			if (linea.Length != INPUT_LINE_LENGTH)
			{
				throw new ApplicationException("La linea ingresada es invalida, debe tener " + INPUT_LINE_LENGTH + " caracteres");
			}
			try
			{
				DateTime FechaHora = DateTime.ParseExact(linea.Substring(0, 14), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
				Double Temperatura = Convert.ToDouble(linea.Substring(14, 3)) / 10;
				Double Humedad = Convert.ToDouble(linea.Substring(17, 3)) / 10;
				String CodigoSensor = linea.Substring(20, 4);
				Boolean EstadoSensor = Convert.ToBoolean(Convert.ToInt32(linea.Substring(24, 1)));
				return new Registro(FechaHora, Temperatura, Humedad, CodigoSensor, EstadoSensor);
			}
			catch(Exception ex)
			{
				throw new ApplicationException("Input no respeta formato" + ex);
			}
		}
			
		 internal List<Registro> LeerInput(string InputPath)
		{
			
			try
			{
				StreamReader sr = new StreamReader(InputPath);
				string line;
					while ((line = sr.ReadLine()) != null)
					{
						ListaDeLineasArchivo.Add(ParseoLineaInput(line));
					}
				sr.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read");
				Console.WriteLine(e.Message);
			}
			/*finally
			{
				
			}*/

			return ListaDeLineasArchivo;
		}

	}
}