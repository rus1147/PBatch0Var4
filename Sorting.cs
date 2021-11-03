using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NLog.Internal;
using System.Collections.Specialized;

namespace PractocaBatch4__Rus
{
	public class Sorting
	{
		internal List<Registro> Ordenamiento(List<Registro> regs)
		{
			switch (GetSortMethodConfig())
			{
				case "BubbleSort":
					return BubbleSort(regs);
				case "LinqSort":
					return LinqSort(regs);
				case "DelegadosSort":
					return BubbleSort(regs);
				default:
					return DelegadosSort(regs);
			}
		}
		List<Registro> BubbleSort(List<Registro> registros)
		{
			Registro y;
			for(int i=0; i < registros.Count - 2; i++)
			{
				for (int j = 0; j < registros.Count - 2; j++)
				{
					if(registros[j].FechaHora < registros[j + 1].FechaHora)
					{
						y = registros[j + 1];
						registros[j + 1] = registros[j];
						registros[j]=y;
					}
				}
			}
			return registros;
		}
		List<Registro> LinqSort(List<Registro> registros)
		{

			return registros.OrderByDescending(x => x.FechaHora).ToList();
		}
		List<Registro> DelegadosSort(List<Registro> registros)
		{
			registros.Sort(
				delegate (Registro a, Registro b)
				{
					return b.FechaHora.CompareTo(a.FechaHora);
				});
			return registros;
		}
		private static string GetSortMethodConfig()
		{
			string strr= ConfigurationManager.AppSettings.Get("BubbleSort");
			return strr;
		}
	}
}
