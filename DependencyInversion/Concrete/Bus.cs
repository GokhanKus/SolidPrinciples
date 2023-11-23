using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
	public class Bus: ITasit /*IPedal,ISignal*/
	{
        public Bus()
        {
            Console.WriteLine("Otobus Çalıştı");
        }
        public void GazaBas()
		{
            Console.WriteLine("Otobus Gaza Bastı");
        }

        public void FrenYap()
        {
            Console.WriteLine("Otobus Fren Yaptı");
        }

        public void SagaSinyal()
        {
            Console.WriteLine("Otobus Sağa Sinya Verdi");
        }

		public void SolaSinyal()
		{
			Console.WriteLine("Otobus Sola Sinyal Verdi");


		}

		public void Gazla()
		{
			GazaBas();
		}

		public void Frenle()
		{
			FrenYap();
		}

		public void SagaSinyalVer()
		{
			SagaSinyal();
		}

		public void SolaSinyalVer()
		{
			SolaSinyal();
		}
	}
}
