using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
	public class Car: ITasit /*ISignal,IPedal*/
	{
		public Car()
		{
			Console.WriteLine("Araba Çalıştı");
		}
		public void BasGaza()
		{
			Console.WriteLine("Araba Gaza Bastı");
		}

		public void FreneBas()
		{
			Console.WriteLine("Araba Fren Yaptı");
		}

		public void Frenle()
		{
			FreneBas();
		}

		public void Gazla()
		{
			BasGaza();
		}

		public void SagaSinyalVer()
		{
			Console.WriteLine("Araba Sağa Sinya Verdi");
		}

		public void SolaSinyalVer()
		{
			Console.WriteLine("Araba Sola Sinya Verdi");
		}

	}
}
