using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace PizzaKemence
{
	internal class Felhasznalo
	{
		private PizzaOven kemence;
		private List<int> penztarca;
		private static Random rnd = new Random();
		private string[] kedvencPizzak = { "Margherita", "Sonkás", "Hawaii", "Songoku", "Magyaros" };

		public Felhasznalo(PizzaOven kemence, List<int> kezdoPenz)
		{
			this.kemence = kemence;
			this.penztarca = kezdoPenz;
		}

		public void Rendel()
		{
			while (true)
			{
				Thread.Sleep(rnd.Next(4000, 7001));
				int aktualisEgyenleg = penztarca.Sum();

				string nev = kedvencPizzak[rnd.Next(kedvencPizzak.Length)];
				int meret = rnd.Next(20, 41);
				int ar = meret * 100; // Ár kiszámítása a rendeléskor
				Pizza rendelendo = new Pizza(nev, meret, ar);

				if (aktualisEgyenleg >= rendelendo.Ar)
				{
					Console.WriteLine($"Felhasználó rendel: {rendelendo}. (Egyenleg: {aktualisEgyenleg} Ft)");
					int kifizetve = 0;
					while (kifizetve < rendelendo.Ar && penztarca.Count > 0)
					{
						kifizetve += penztarca[0];
						penztarca.RemoveAt(0);
					}
					if (kifizetve > rendelendo.Ar)
					{
						penztarca.Add(kifizetve - rendelendo.Ar);
					}
					kemence.FeladPizza(rendelendo);
				}
				else
				{
					Console.WriteLine($"Nincs elég pénz a rendeléshez! Szükséges: {rendelendo.Ar} Ft, Van: {aktualisEgyenleg} Ft");
					break;
				}
			}
		}
	}
}