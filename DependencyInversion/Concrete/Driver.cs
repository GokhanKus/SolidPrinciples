using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
	public class Driver
	{

		ITasit t1 = new Bus();
		//ITasit t1 = new Bicycle();
		//ITasit t1 = new Car(); dependency inversion yaptık bagımlılık ortadan kaldırıldı.



		public void Use()
		{
			t1.Gazla();
			t1.Frenle();

			t1.SagaSinyalVer();
			t1.SolaSinyalVer();


		}	

	}
}
