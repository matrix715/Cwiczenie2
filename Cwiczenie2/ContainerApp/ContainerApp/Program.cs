using ContainerApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var ship = new Ship("Titanic", 25, 5000, 200);
        var container1 = new LiquidContainer("KON-L-1") { MaxLoad = 1000 };
        var container2 = new GasContainer("KON-G-1") { MaxLoad = 800 };
        var container3 = new RefrigeratedContainer("KON-C-1") { MaxLoad = 500 };

        ship.LoadContainer(container1);
        ship.LoadContainer(container2);
        ship.LoadContainer(container3);

        Console.WriteLine(ship.GetShipInfo());
    }
}