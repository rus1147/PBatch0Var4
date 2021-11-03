using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractocaBatch4__Rus
{
	public class OutputFormat
	{
		public enum DisplayFormat { shortformat, longformat }

		internal List<string> listaRegistros = new List<string>();
		 string LongFormat(Registro registro)
		{
			string output =
			@"Fecha del registro: " + registro.FechaHora.ToString("yyyy/MM/dd") + "\n" +
			@"Hora del registro: " + registro.FechaHora.Hour + "Hs " + registro.FechaHora.Minute + "Min " + registro.FechaHora.Second + "Seg " + "\n" +
			@"Temperatura: " + registro.Temperatura.ToString().Replace(".", ",") + '°' + "\n" +
			@"Humedad: " + registro.Humedad.ToString().Replace(".", ",") + '%' + "\n" +
			@"Código: " + registro.CodigoSensor + "\n" +
			@"Activo: " + (registro.EstadoSensor ? "SI" : "NO");
			return output;
		}

		

		string ShortFormat(Registro registro)
		{
			string output =
			@"Fecha/Hora registro: " + registro.FechaHora.ToString("yyyy/MM/dd HH/mm/ss") + ".000" + "\n" +
			@"Temperatura: " + registro.Temperatura.ToString().Replace(".", ",") + '°' + "\n" +
			@"Humedad: " + registro.Humedad.ToString().Replace(".", ",") + '%' + "\n" +
			@"Código: " + registro.CodigoSensor + "\n" +
			@"Activo: " + (registro.EstadoSensor ? "SI" : "NO");
			return output;
		}


		internal List<string> DarFormatoALista(List<Registro> registros, string inputFormat)
		{

			if (inputFormat == DisplayFormat.shortformat.ToString())
			{
				foreach (Registro r in registros)
				{
					string reg = this.ShortFormat(r);
					listaRegistros.Add(reg);
				}
				return listaRegistros;
			}
			else{
				foreach (Registro r in registros)
				{
					string reg = this.LongFormat(r);
					listaRegistros.Add(reg);
				}
				return listaRegistros;
			}
		}
	}
}
