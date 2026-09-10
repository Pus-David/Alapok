using Jatekos;

Jatek jatekos = new Jatek();

jatekos.Nev = "Jatékos1";
jatekos.Elet = 120; //Elet will be set to 100 due to the setter logic
Console.WriteLine($"Név: {jatekos.Nev}, Élet: {jatekos.Elet}");
jatekos.Elet = -20;
Console.WriteLine($"Név: {jatekos.Nev}, Élet: {jatekos.Elet}");