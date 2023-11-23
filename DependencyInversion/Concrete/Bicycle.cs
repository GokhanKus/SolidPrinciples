using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
	public class Bicycle : ITasit
	{
		public void Frenle()
		{
            Console.WriteLine("mandal skildi yavasladı");
        }

		public void Gazla()
		{
			Console.WriteLine("pedal cevrildi hızlandı");

		}

		public void SagaSinyalVer()
		{
			Console.WriteLine("sinyal verildi");
		}

		public void SolaSinyalVer()
		{
			Console.WriteLine("sinyal verildi");
		}
	}
}
