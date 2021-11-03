using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractocaBatch4__Rus
{
	class Registro
	{
		public DateTime FechaHora { get; set; }
		public Double Temperatura { get; set; }
		public Double Humedad	{ get; set; }
		public String CodigoSensor { get; set; }
		public Boolean EstadoSensor { get; set; }

		internal Registro(DateTime fechaHora, Double temperatura, Double humedad, String codSensor, Boolean estadoSensor)
		{
			this.FechaHora = fechaHora;
			this.Temperatura = temperatura;
			this.Humedad = humedad;
			this.CodigoSensor = codSensor;
			this.EstadoSensor = estadoSensor;
		}
	}
}
