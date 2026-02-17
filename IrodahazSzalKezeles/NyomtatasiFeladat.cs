using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrodahazSzalKezeles
{
	internal class NyomtatasiFeladat
	{
		private string cimzett;
		private int oldalak;

		public NyomtatasiFeladat(string cimzett, int oldalak)
		{
			this.cimzett = cimzett;
			this.oldalak = oldalak;
		}

		public string Cimzett { get => cimzett; set => cimzett = value; }
		public int Oldal { get => oldalak; set => oldalak = value; }

		public override string ToString()
		{
			return $"{this.cimzett} {this.oldalak} oldal";
		}
	}
}
