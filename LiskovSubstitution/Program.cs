//using LiskovSubstitution_NotIdealCode;
using LiskovSubstitution_IdealCode;

namespace LiskovSubstitution
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region NotIdealCode
			
			//Cloud cloud = new Amazon();
			//cloud.MachineLearning();
			//cloud.Translate();

			//cloud = new Azure();
			//cloud.MachineLearning();
			//cloud.Translate(); //burası hata verecek dogru gorunsede azure'de translate fonksiyonunun ici bos abstract ve interfacelerin dayatmasından dolayı zorunlu olarak ekledik ama ici bos istenmeyen durum

			//cloud = new Google();
			//cloud.MachineLearning();
			//cloud.Translate();

			#endregion

			#region IdealCode

			ICloud cloud = new Amazon();
			cloud.MachineLearning();
			(cloud as ITranslatable)?.Translate(); //Amazon classı ITranslate mi? oyle bir davranısı var mı
												   //Translate fonksiyonu var mı varsa uygula Liskov ilkesi budur

			cloud = new Azure();
			cloud.MachineLearning();
			(cloud as ITranslatable)?.Translate();  //LSP ilkesi

			cloud = new Google();
			cloud.MachineLearning();
			(cloud as ITranslatable)?.Translate();	//LSP ilkesi

			#endregion
		}
	}
}
/*
Liskov Substitution prensibi ortak bir referanstan türeyen (abstract class interface vs.) nesnelerin hiçbir şeyi bozulmadan problem olmadan birbirleriyle degistirilmesi gerektigini 
yani birbirleri yerine gecebilmesi gerektigini oneren bir prensiptir. PolyMorphism(cok bicimlilik) gibi ama farkı var ve farkı şu;

eger bir class any bir interface veya abstract class ile sozleşme yaparsa o zaman bu sozlesmeyi karsilamalı ve gerekli tum memberları icerisinde tanımlamalıdır.

eger bu memberlardan bos ve islevsiz olan varsa orada problem var demektir oyle olmamalı yani interfaceden implement edilen veya 
abstract classtan override edilen metotlar bos kalmamalıdır veya bossa not implement exception gibi hatalar döndürülmemelidir.

liskov ilkesi bunu soyler. yapılmadıgı taktirde olabilecek problemler;
polymorphism geregi yer degistirebilirler, ama iclerindeki kimi memberlar islevsiz kalacagi icin calısma surecinde patlamalara sebep olabilir
mesela base classımız olsun(interface) icinde A() B() C() metotları olsun bunu class1, class2, class3 e implement ettigimizde butun fonk.ları mecbur olusturuyoruz bilindigi uzere
class1de zorunlu implement ettigimiz 3 metotta doldurulsun kullanılacak yani, class2'de A() metodu boş, class3'te de B() metodu bos olsun
polymorpladıgımızda (Base ornek = new class1()) (Base ornek = new class2) class2de A() metodu bos olmasına ragmen burada kullanılabilir oldugunu goruruz bu istenmeyen durumdur patlayabilir.

yani ozet olarak LSP(liskov substitution principle) bize nesnelerin sadece gercek ve islevsel olanların oldugu bir senaryo soyler.
bir nesnenin arayüz tarafından dayatılan taahhtütnamedeki, sozlesmedeki davranısları yerine getirmedigi durumlarda LSP ilkesine aykırılık soz konusudur.

 */