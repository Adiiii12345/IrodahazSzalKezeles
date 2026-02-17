using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrodahazSzalKezeles
{
	internal class Dolgozo
	{
		private Nyomtato nyomtato;
		private static Random r = new Random();
		private static string[] nevek = { "Kis", "Nagy", "Szabó", "Tóth", "Kovács" };

		public Dolgozo(Nyomtato nyomtato)
		{
			this.nyomtato = nyomtato;
		}


		public void Futtat()
		{
			while (true)
			{
				Thread.Sleep(2000);
				string nev = nevek[r.Next(0, nevek.Length)];
				int oldalak = r.Next(0, 10);
				NyomtatasiFeladat feladat = new NyomtatasiFeladat(nev, oldalak);
			
			nyomtato.Hozzaad(feladat);
				Console.WriteLine($"Dolgozó :  {feladat}");

			}

		
		}  
	
	}
	
}
