namespace IrodahazSzalKezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nyomtato nyomtato = new Nyomtato(5);

            Postazo postazo = new Postazo(nyomtato);
            Dolgozo dolgozo = new Dolgozo(nyomtato);

            Thread dolgozoSzal = new Thread(dolgozo.Futtat);
            Thread postazoSzal = new Thread(postazo.Futtat);

            dolgozoSzal.Start();
            postazoSzal.Start();
		}
    }
}
