using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
	//bagımlılıkları esnek hale getirdik temiz kod.
	internal class MailSender
	{
		public void SendEmail(IEmailServer emailServer)
		{
			emailServer.SendEmail("example@example.com", "content"); //default mail gonderme
		}
		//public void GmailSendEmail(GmailSender gmailSender)
		//{
		//	gmailSender.SendEmail("example@gmail.com", "this is gmail"); //gmail mail gonderme
		//}
		//public void HotmailSendEmail(HotmailSender hotmailSender)
		//{
		//	hotmailSender.SendEmail("example@hotmail.com", "this is hotmail "); //hotmail gonderme
		//}

	}
	interface IEmailServer
	{
		void SendEmail(string to, string body);
	}
	class GmailSender : IEmailServer
	{
		public void SendEmail(string to, string body)
		{

		}
	}
	public class HotmailSender : IEmailServer
	{
		public void SendEmail(string to, string body)
		{

		}
		
	}
	class YandexSender : IEmailServer
	{
		public void SendEmail(string to, string body)
		{

		}
	}
}

