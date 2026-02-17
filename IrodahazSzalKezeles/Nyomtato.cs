using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrodahazSzalKezeles
{
	internal class Nyomtato
	{

		private SzinkronPuffer<NyomtatasiFeladat> puffer;

		public Nyomtato(int meret)
		{
			this.puffer = new SzinkronPuffer<NyomtatasiFeladat>(meret);
		}
		public void Hozzaad(NyomtatasiFeladat feladat)
		{
			puffer.Hozzaad(feladat);
		}

		public NyomtatasiFeladat Kivesz()
		{
			return puffer.Kivesz();
		}
	}
}
