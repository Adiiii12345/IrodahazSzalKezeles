namespace PizzaKemence
{
	internal class PizzaOven
	{
		private SzinkronPuffer<Pizza> puffer;

		public PizzaOven(int meret)
		{
			this.puffer = new SzinkronPuffer<Pizza>(meret);
		}

		public void FeladPizza(Pizza pizza)
		{
			puffer.Hozzaad(pizza);
		}

		public Pizza KiveszPizza()
		{
			return this.puffer.Kivesz();
		}
	}
}