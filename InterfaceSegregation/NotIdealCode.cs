using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_NotIdealCode
{
	interface IPrinter
	{
		void Print();
		void Fax();
		void Scan();
		void PrintDuplex();
	}
	class SamsungPrinter : IPrinter
	{
		public void Fax()
		{
			Console.WriteLine("Fax Islemi");
		}

		public void Print()
		{
			Console.WriteLine("Print Islemi");
		}

		public void PrintDuplex()
		{
			Console.WriteLine("PrintDuplex Islemi");
		}

		public void Scan()
		{
			Console.WriteLine("Scan Islemi");
		}
	}
	class HpPrinter : IPrinter
	{
		public void Fax()
		{
            Console.WriteLine("Fax Islemi");
        }

		public void Print()
		{
			Console.WriteLine("Print Islemi");
		}

		public void PrintDuplex()
		{
            Console.WriteLine("PrintDuplex Islemi");
        }

		public void Scan()
		{
			throw new NotSupportedException(); //bu fonk HpPrinterda mevcut degil ama implement zorunlu, olmayan fonksiyonu eklemek zorunda kaldık ISP'ye aykırı
		}
	}
	class DellPrinter : IPrinter
	{
		public void Fax()
		{
			Console.WriteLine("Fax Islemi");
		}

		public void Print()
		{
			Console.WriteLine("Print Islemi");
		}

		public void PrintDuplex()
		{
			throw new NotSupportedException(); //bu fonk dellprinterda mevcut degil ama implement zorunlu, olmayan fonksiyonu eklemek zorunda kaldık ISP'ye aykırı
		}

		public void Scan()
		{
            Console.WriteLine("Scan Islemi");
        }
	}
}
