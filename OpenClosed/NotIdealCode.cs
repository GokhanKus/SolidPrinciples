using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
	class NotIdealCode
	{
		public void Gonder(int tutar)
		{
			//kodun degistirilebildigi senaryo biz bunu istemeyiz, gelistirilebilir oldugu senaryoyu isteriz.
			//Garanti garanti = new Garanti();
			//garanti.HesapNo = "asd";
			//garanti.ParaGonder(tutar);e simdi artık halkbank ile islem yapacagımız zaman burayı temizleyip halkbank ile nesne olusturup onla ilgili islemleri tekrar yazacagız zahmetli ve karmasık 

			HalkBank halkBank = new HalkBank();
			halkBank.GonderilecekHesapNo("123");
			halkBank.Gonder(tutar); //yine aynı sekilde baska banka geldiginde burayı silip o classtan nesne ornegi türetip ilgili classa ait farklı ozellikleri kullanmak zorunda kalacagız boyle yapmamalıyız.
		}
	}
	class GarantiBankasi
	{
		public string HesapNo { get; set; }
		public void ParaGonder(int tutar)
		{
			//...
		}
	}
	class HalkBankasi
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
	}

}
