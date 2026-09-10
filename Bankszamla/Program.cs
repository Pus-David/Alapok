using Bankszamla;

Console.WriteLine("Befizetés: 1; Kifizetés: 2");
string irany = Console.ReadLine();
bankszamla peldany = new bankszamla();

if (irany == "1")
{
    Console.WriteLine("Kérem a befizetni kívánt összeget:");
    double be = Convert.ToDouble(Console.ReadLine());
    peldany.befizetes(be);
}
else
{
    Console.WriteLine("Kérem a kifizetni kívánt összeget:");
    double ki = Convert.ToDouble(Console.ReadLine());
    peldany.kifizetes(ki);
}