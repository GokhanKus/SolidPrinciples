//using InterfaceSegregation_NotIdealCode;
using InterfaceSegregation_IdealCode;

namespace InterfaceSegregation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region NotIdealCode

			//SamsungPrinter samsungPrinter = new SamsungPrinter(); //samsungda butun fonklar oldugu icin problem yok
			//samsungPrinter.Scan();
			//samsungPrinter.Print();
			//samsungPrinter.Fax();
			//samsungPrinter.PrintDuplex();

			//	HpPrinter hpPrinter = new HpPrinter();  //ancak hpprinterda scan fonksiyonu olmadıgı icin hatayı alırız boyle bir metodu olmasına ragmen islevi olmayan bir metot ISP'ye aykırı
			//hpPrinter.Scan();//scan ozelligi hpprinterda yok
			//hpPrinter.Print();
			//hpPrinter.Fax();
			//hpPrinter.PrintDuplex();

			//	DellPrinter dellPrinter = new DellPrinter();
			//dellPrinter.Scan();
			//dellPrinter.Print();
			//dellPrinter.Fax();
			//dellPrinter.PrintDuplex(); //printduplex ozelligi dellprinterında yok

			#endregion

			#region IdealCode

			SamsungPrinter samsungPrinter = new SamsungPrinter();
			samsungPrinter.Scan();
			samsungPrinter.Print();
			samsungPrinter.Fax();
			samsungPrinter.PrintDuplex();

			HpPrinter hpPrinter = new HpPrinter(); //hpprinterda scan fonksiyonu olmadıgı icin "." dedigimizde gelmiyor ISP sayesinde düzelttik
			hpPrinter.Print();
			hpPrinter.Fax();
			hpPrinter.PrintDuplex();


			DellPrinter dellPrinter = new DellPrinter(); //aynı sekilde dellprinterda da printduplex fonksiyonu yok.
			dellPrinter.Scan();
			dellPrinter.Print();
			dellPrinter.Fax();

			#endregion
		}
	}
}
/*
Interface Segregation principle (arayüz ayrım prensibi) 
bir nesnenin yapması gereken davranış(lar)ın, o davranış(lar)a odaklanmış ozel interface'ler ile eslesmesini oneren prensiptir.

boylece ihtiyac olan davranısları, temsil eden interfaceler esliginde ilgili sınıflara kazandırılabilir ve hicbir sınıfın kullanmadıgı bir imzayı 
zorla implement etmek zorunda kalmaksızın insa surecine devam edebiliriz.

ornegin printer interfacemiz olsun ve bu arayuzde print(), fax(), printdublex() ve scan() fonkları olsun ve biz bu interfaceyi 
SamsungPrinter.cs, HpPrinter, DellPrinter classlarına implement edelim, ama diyelim ki 
samsung printerinde scan() ozelligi olmasın, dell printerde de printdublex() olmasın, ama interface implement ettigimiz icin mecbur fonksiyonları olusturuyoruz 
e madem printerların oyle bir fonksiyonu yok neden olusturalım ISP(Interface Segregation) burada devreye giriyor.
 */