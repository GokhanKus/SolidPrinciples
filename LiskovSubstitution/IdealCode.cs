using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_IdealCode
{
	abstract class ICloud
	{
		public abstract void MachineLearning();
	}
	interface ITranslatable
	{
		void Translate();
	}
	class Amazon : ICloud, ITranslatable
	{
		public override void MachineLearning()
		{
			Console.WriteLine("Amazon Machine Learning");
		}
		public void Translate()
		{
			Console.WriteLine("Amazon Translate");
		}
	}
	class Azure : ICloud //Azurede Translate ozelligi olmadıgı icin buraya kalıtım olarak vermedik LSP ILKESINI UYGULADIK
	{
		public override void MachineLearning()
		{
			Console.WriteLine("Azure Machine Learning");
		}
	}
	class Google : ICloud, ITranslatable
	{
		public override void MachineLearning()
		{
			Console.WriteLine("Google Machine Learning");
		}
		public void Translate()
		{
			Console.WriteLine("Google Translate");
		}
	}
	class Yandex : ITranslatable //ornegin yandex'te ICloud / machine learning ozelligi olmasın
	{
		public void Translate()
		{
			Console.WriteLine("Yandex Translate");
		}
	}
}
