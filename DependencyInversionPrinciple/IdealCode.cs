using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple_IdealCode
{
	internal class MailService
	{
		public void SendMail(IMailServer mailServer)
		{
			mailServer.Send("mail", "to");
		}
	}
	interface IMailServer
	{
		void Send(string mail, string to);
	}
	class Gmail : IMailServer
	{
		public void Send(string mail, string to)
		{

		}
	}
	class Hotmail : IMailServer
	{
		public void Send(string mail, string to)
		{

		}
	}
	class Yandex : IMailServer
	{
		public void Send(string mail, string to)
		{

		}
	}
}
