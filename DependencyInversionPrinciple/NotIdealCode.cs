using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple_NotIdealCode
{
	//ideal olmayan kod yapisi burada MailServisi Gmaile bagimli
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
