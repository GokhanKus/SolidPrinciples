namespace OpenClosed
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//IdealCode.cs sayesinde Open Closed prensibine uygun tasarım yaptık. kodu degistirmek yerine genisletiyoruz. farklı bankalar ile esnek bir sekilde calisabiliriz.
			ParaGonderici paraGonderici = new ParaGonderici();
			paraGonderici.Gonder(new Garanti(), 100000, "1.hesap no garantibank");
			paraGonderici.Gonder(new HalkBank(), 50000, "2.hesap no halkbank");
		}
	}
	

}

/*
Kodun genisletilmesi Open, degistirilmesi Closed
Open Closed prensibi OOP tasarımlarında bir classın DEGISTIRILMEYE gerek duyulmaksızın GENISLETILEBILIR bir sekilde tasarlanmasını savunan bir prensiptir.
kodun genisletilmesi demek, kodu degistirmeksizin yeni gereksinime gore gelecek olan davranısın uygulamaya eklenmesidir. OC Prensibi bunu savunur

 */