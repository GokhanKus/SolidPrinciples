using DependencyInversion.Concrete;

namespace DependencyInversion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Driver d1 = new Driver();

			d1.Use();

			//Solid prensipleri, gerçek hayattan alınan ve yazılım süreclerinde uygulanan prensiplerdir
		}
	}
}