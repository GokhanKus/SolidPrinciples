using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
	class ParaGonderici
	{
		public void Gonder(IBank bank, int tutar, string hesapNo)
		{
			bank.ParaTransfer(tutar, hesapNo);
		}
	}
	interface IBank
	{
		bool ParaTransfer(int tutar, string hesapNo);
	}
	class Garanti:IBank
	{
		public string HesapNo { get; set; }
		public void ParaGonder(int tutar)
		{
			//...
		}

		public bool ParaTransfer(int tutar, string hesapNo)
		{
			try
			{
				ParaGonder(tutar);
				HesapNo = hesapNo;
				return true;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
	class HalkBank:IBank
	{
		string hesapNo;
		public void GonderilecekHesapNo(string hesapNo)
		{
			//...
		}
		public void Gonder(int tutar)
		{
			//...
		}

		public bool ParaTransfer(int tutar, string hesapNo)
		{
			try
			{
				GonderilecekHesapNo(hesapNo);
				Gonder(tutar);
                Console.WriteLine($"Halkbank ile {hesapNo} numarali hesaba {tutar} lira para transfer edildi");
                return true;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}

}
