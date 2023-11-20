namespace SingleResponsibility
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			
		}
	}
}
/*
single responsibility principle, aynanda tek bir iş herkes tek bir iş yapsın
srp oop tasarımlarında bir classı mümkünse tek bir sorumluluga odaklı insa edilmesini gerektigini savunur
ve bir sınıfın degistirilmesi icin yalnızca tek bir nedeni olması gerekmektedir, birden fazla sebep varsa srp'ye uygun degildir, yani o classın birden fazla gorevi oldugu anlamına gelmektedir.
ornegin bir class aritmetiksel islemler yapabilir(toplama cıkarma carpma vb) ve o class icerisindeki metotların tek bir gorevi vardır topla() cıkart() carp() vb bu srpye uygun
solide uymayan tasarımlar kırılgan tasarımlar olarak nitelendirilir

*/