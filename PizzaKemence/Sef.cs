using PizzaKemence;
using System;
using System.Threading;


namespace PizzaKemence
{
	internal class Sef
	{
		private PizzaOven kemence;
		private static Random rnd = new Random();
		private string[] nevek = { "Margherita", "Sonkás", "Hawaii", "Songoku" };

		public Sef(PizzaOven kemence)
		{
			this.kemence = kemence;
		}

		public void Dolgozik()
		{
			while (true)
			{
				Thread.Sleep(rnd.Next(2000, 3001));

				string nev = nevek[rnd.Next(nevek.Length)];
				int meret = rnd.Next(20, 41);
				int ar = meret * 100;
				Pizza p = new Pizza(nev, meret, ar);

				kemence.FeladPizza(p);
				Console.WriteLine($"Séf készítette: {p}");
			}
		}
	}
}