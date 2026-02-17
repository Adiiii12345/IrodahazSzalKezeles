using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaKemence
{
	internal class Futar
	{
		private PizzaOven kemence;

		public Futar(PizzaOven kemence)
		{
			this.kemence = kemence;
		}

		public void Kiszallit()
		{
			while (true)
			{
				Pizza p = kemence.KiveszPizza();

				Thread.Sleep(p.Meret * 100);

				Console.WriteLine($"Futár szállította: {p}");
			}
		}
	}
}