using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrodahazSzalKezeles
{
	internal class Postazo
	{
		private Nyomtato nyomtato;
		public Postazo(Nyomtato nyomtato)
		{
			this.nyomtato = nyomtato;
		}

		public void Futtat()
		{
			while (true)
			{
				Thread.Sleep(3000);
				NyomtatasiFeladat feladat = nyomtato.Kivesz();
				Console.WriteLine($"Postazva: {feladat}");
			}
		}
	}
}
