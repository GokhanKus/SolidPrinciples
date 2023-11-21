using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LiskovSubstitution_NotIdealCode
{
	abstract class Cloud
	{
		//IdealCode kısmında alttaki classların hepsinde ortak olanları yani sadece machinelearning fonksiyonunu burada tanımlayacagız
		//Transalte()fonksiyononunu farklı interface&abstract classta tanımlayacagız.
		public abstract void MachineLearning();
		public abstract void Translate();
	}
	class Amazon : Cloud
	{
		public override void MachineLearning() => Console.WriteLine("Amazon MachineLearning");
		// "=>" lambda ifadesi basit ve tek satırlık metotlar icin kullanılabilir scope{} yerine .. 
		public override void Translate() => Console.WriteLine("Amazon Translate");
		
	}
	class Azure : Cloud
	{
		public override void MachineLearning()
		{
            Console.WriteLine("Azure Machine Learning");
        }

		public override void Translate()
		{
			throw new NotImplementedException();
			//LISKOV SIBSTITUTION PRINCIPLE ye aykırı olan yer ici bos olsaydı da aykırı olurdu ideal olmayan kod.
		}
	}
	class Google : Cloud
	{
		public override void MachineLearning()
		{
            Console.WriteLine("Google Machine Learning");
        }

		public override void Translate()
		{
            Console.WriteLine("Google Translate");
        }
	}
	

}
