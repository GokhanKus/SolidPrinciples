using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_IdealCode
{
	//mumkun oldugu kadar interfaceleri ayırdık interface segregation prensibini uyguladık, cunku ver printerda her ozellik yok.
	interface IPrint
	{
		void Print();
	}
	interface IFax
	{
		void Fax();
	}
	interface IPrintDuplex
	{
		void PrintDuplex();
	}
	interface IScan
	{
		void Scan();
	}
	class SamsungPrinter : IPrint, IFax, IPrintDuplex, IScan
	{
		public void Fax() => Console.WriteLine("Fax Islemi");
		public void Print() => Console.WriteLine("Print Islemi");
		public void PrintDuplex() => Console.WriteLine("PrintDuplex Islemi");
		public void Scan() => Console.WriteLine("Scan Islemi");
		
	}
	class HpPrinter : IPrint, IFax, IPrintDuplex
	{
		public void Fax() => Console.WriteLine("Fax Islemi");
		public void Print() => Console.WriteLine("Print Islemi");
		public void PrintDuplex() => Console.WriteLine("PrintDuplex Islemi");
	}
	class DellPrinter : IPrint, IFax, IScan
	{
		public void Fax() => Console.WriteLine("Fax Islemi");
		public void Print() => Console.WriteLine("Print Islemi");
		public void Scan() => Console.WriteLine("Scan Islemi");

	}
}
