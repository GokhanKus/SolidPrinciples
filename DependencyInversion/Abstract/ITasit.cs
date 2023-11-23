using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Abstract
{
	public interface ITasit
	{
		//Sözleşme taahhüt, interfce kullanan sınıf bu interface'in metotlarını kullanmayı taahhüt etmeiş olur.
		//interface içerisinde metot imzası olur.
		//erisim belirleyiciye gerk yokk puvlic olur burada default
		//metot bodysi interfacede olmaz

		void Gazla();

		void Frenle();

		void SagaSinyalVer();

		void SolaSinyalVer();
		
		
	}
}
