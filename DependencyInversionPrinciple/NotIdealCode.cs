using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple_NotIdealCode
{
	//burada mailservicemiz direkt gmaile bagimli, gmailde skinti olursa tekrar diger mail servisleri (hotmail,yandex vs.) tekrar yapılandirmamiz gerekecek.
	internal class MailService
	{
		public void SendMail(Gmail gmail)
		{
			gmail.Send("...");
		}
		
	}
	class Gmail
	{
		public void Send(string mail) { }
	}
	class Hotmail
	{
		public void Send(string mail,string to) { }
	}
	class Yandex
	{
		public void Send(string mail) { }
	}
}
