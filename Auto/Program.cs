using Auto;
Autok piros = new Autok();
piros.Marka = "Toyota";
piros.Eletkor = 5;

Autok kek = new Autok();
Console.Write("Kérem az autó márkáját:");
kek.Marka = Console.ReadLine();
Console.Write("kéream az auto eletkorat");
kek.Eletkor = int.Parse(Console.ReadLine());

Console.WriteLine($"1. példány: {piros.Marka},{piros.Eletkor}");
Console.WriteLine($"2. példány: {kek.Marka},{kek.Eletkor}");
