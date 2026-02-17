using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class Pizza
	{

		private string nev;
		private int meret;

		public Pizza(string nev, int meret)
		{
			this.nev = nev;
			this.meret = meret;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Meret { get => meret; set => meret = value; }

		public override string ToString()
		{
			return $"{this.nev} {this.meret} cm";
		}
	}
}
