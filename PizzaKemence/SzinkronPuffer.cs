using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class SzinkronPuffer <T>
	{
		private Queue<T> queue;
		private int meret;
		private readonly object zar = new object();
		public SzinkronPuffer(int meret)
		{
			this.meret = meret;
			this.queue = new Queue<T>();
		}


		public int Meret
		{
			get { return meret; }
		}

		public void Hozzaad(T item)
		{
			lock (zar)
			{
				while (queue.Count == meret)
				{
					Monitor.Wait(zar);
				}
				queue.Enqueue(item);
				Monitor.PulseAll(zar);
			}
		}

		public T Kivesz()
		{
			lock (zar)
			{
				while (queue.Count == 0)
				{
					Monitor.Wait(zar);
				}
				T item = queue.Dequeue();
				Monitor.PulseAll(zar);
				return item;
			}
		}
	}
}
