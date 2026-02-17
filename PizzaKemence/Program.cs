using System;
using System.Collections.Generic;
using System.Threading;


namespace PizzaKemence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PizzaOven kemence = new PizzaOven(5);

		
			for (int i = 0; i < 2; i++)
			{
				Sef sef = new Sef(kemence);
				Thread sefSzal = new Thread(sef.Dolgozik);
				sefSzal.Start();
			}

		
			Futar futar = new Futar(kemence);
			Thread futarSzal = new Thread(futar.Kiszallit);
			futarSzal.Start();

			List<int> kezdoPenz = new List<int> { 5000, 2000, 1000, 5000, 2000 };
			Felhasznalo felhasznalo = new Felhasznalo(kemence, kezdoPenz);
			Thread felhasznaloSzal = new Thread(felhasznalo.Rendel);
			felhasznaloSzal.Start();

			Console.WriteLine("A rendszer fut");
		}
	}
}