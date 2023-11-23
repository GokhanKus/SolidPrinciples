//using DependencyInversionPrinciple_NotIdealCode;

using DependencyInversionPrinciple_IdealCode;

namespace DependencyInversionPrinciple
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region NotIdealCode

			//MailService mailService = new MailService();
			//mailService.SendMail(new Gmail()); //burasi bizden sadece gmail bekler gmaile bagimli
			//gmailde skinti olursa diger mailleri kullanamayiz bagimli degil bagimlili tersine cevirerek gmail,yandex,hotmaili mail servise bagimli etmemiz latim tersine cevirerek.

			#endregion

			#region IdealCode

			MailService mailService = new MailService();
			mailService.SendMail(new Gmail());	 //goruldugu uzere MailServicenin tek gmaile olan bagimlili ortadan kaldırıp tersine cevirdik.
			mailService.SendMail(new Hotmail()); //artik gmail, yandex ve hotmail, MailService'ye bagli
			mailService.SendMail(new Yandex());

			#endregion
		}
	}
}
/*
DependencyInversionPrinciple(bagimliligin tersine cevrilmesi prensibi) sen bir ürüne bagimli olma o urunun bulundugu sınıf sana bagımlı olsun prensibi
yani gelistiricinin any bir ture bagimli olmadigini, tam tersi turlerin/nesnelerin gelistiriciye bagimli oldugu savunur.

örnegin bir komutanın tek bir askere bagimli oldugu senaryoda yanlış bir hiyerarşi olmuş olur asker mesgul ise komutan o askeri kullanamaz, bu senaryoda komutan tek bir askere bagimlidir
günlük hayatta da oldugu gibi komutan direkt asker classına baglidir yani komutan asker dediginde müsait olan askerler dikkat kesilir yani bu senaryoda da askerler komutana bagimlidir (bagimliligin tersine cevrilmesi)

yazılım tarafında baska bir ornek vermek gerekirse Mailservice sınıfımız olsun bu sınıfta direkt gmail'e bagimli olsun 
ve bir gün gmail servisinde problem olursa aynı kodları farklı mail servislerinde(hotmail, yandex) tekrar yapılandırmak zorunda kalacagiz istenmeyen durum,
onun yerine araya bir tane IMailServer adında bir interface oluşturalım ve MailService bu interfaceyi kullansın 
ve gmail yandex hotmail artık mailservice bagimli olsun, cunku artik istedigimi kullanabilirim

								Hotmail
MailService ==> IMailServer	==>	Gmail
								Yandex

bu prensibi uygularken nesnelerin iletisimini soyut/abstract yapılar uzerinden gerçeklestiriyoruz yani arayüzleri kullanıyoruz.
bu prensip bir sınıfın concrete/somut sınıflarına degil onların soyut/abstraction'larına baglı olmasını soyler. 
Boylece o sınıf any bir somut sinifa bagimli olmayacak tam tersi somut sınıf(lar) ilgili sinifa bagimlilik sergiliyor olacak.


 */