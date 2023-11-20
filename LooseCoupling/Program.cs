
namespace LooseCoupling
{
	internal class MailSenderLooseCoupling
	{
		static void Main(string[] args)
		{
			//Gmail gmail = new("");
			//gmail.Send("mail@example.com");
			Hotmail hotmail = new Hotmail(); //hotmail ile calısacagım zaman bagımlılık yuzunden gmaili kaldırıp hotmail ekledik bunu istemeyiz
				//yani kısacası baska bir class ekleyip mesela yahoo veya yandex etc. Mailsenderda sureklı yıkım insa olacak o yüzden loose coupling esnek hale getirmeliyiz.
			

			MailSender sender = new(); //loose coupling yaptık esnek..
			sender.SendEmail(new GmailSender());
			sender.SendEmail(new HotmailSender());
			sender.SendEmail(new YandexSender());
		}
	}
	class Gmail
	{
		//burada mailsender sınıfı gmail sınıfını kullanıyosa eger mailsender sınıfı gmail sınıfına bagımlıdır deriz
		//ve gmail sınıfı olmadan mailsender sınıfı gorevini yerine getiremeyecektir, cunku sıkı bagımlı ve gmail sınıfında bir degisiklik yapıldıgında mailsender sınıfı da
		//dogrudan etkilenecek ve gerekli duzenlemeleri zorunlu kılacaktır orn string to
		public void Send(string to)
		{

		}
        public Gmail(string a)//mesela boyle bir ctor olusturunca mail olusturma kısmı da hata veriyor bagımlılıgın getirdigi bir problem, bunun icin loose coupling..
        {
            
        }
    }
	class Hotmail
	{

	}
}
/*
Loose Coupling(esnek-bağ) nesneler arasındaki bagımlılıgın esnek olması gerektigini soyler. Bir nesne baska nesneye tied coupling ise yani sıkı bagımlıysa sıkıntı olur maliyet artar problemler meydana gelir
yani nesneler arasındaki bagımlılık minimum olmalı
oop tasarımlarında nesneler arası bagımlılım mecburen olur ve iyi bir tasarım bagımsızlığın oldugu değil, bagımlılıkların kontrol edildigi tasarımlardır.(gunluk hayattan ornek verilebilir)

yukarıdaki sıkıntılı kod loose coupling prensibinden sonra su sekilde olacaktır;


MailSender.cs artık abstract class veya bir interfaceye (IMailServer.cs) bagımlı olsun ve bu interfacete gmail.cs, hotmail.cs, yandex.cs etc.. classlarına uygulansın
artık mailsender clasımız tek bir mail turune bagımlı degil, interface aracılıgıyla esnek hale getirdik.

									==> Gmail.cs
MailSender.cs ==> IMailServer.cs	==> Hotmail.cs
									==> Yandex.cs

yani bir nesne baska nesneye/nesnelere bagımlı olacagı senaryoda araya bir tane interface koyarız ve bu sayede gmail.cs'te hotmail.cs'te olabilecek bir degisiklik mailsender.cs'ı etkilemeyecek



 */