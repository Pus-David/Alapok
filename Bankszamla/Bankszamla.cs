using System;
using System.Collections.Generic;
using System.Text;

namespace Bankszamla
{
    internal class bankszamla
    {
        private double egyenleg;

        public void befizetes(double osszeg)
        {
            if (osszeg > 0)
            {
                egyenleg += osszeg;
                Console.WriteLine($"Befizetés: {osszeg} Ft. új egyenleg: {egyenleg} Ft.");
            }
            else
            {
                Console.WriteLine("A befizetés összege nem lehet negatív");
            }
        }

        public void kifizetes(double osszeg)
        {
            if  (osszeg > 0 && osszeg<=egyenleg)
            {
                egyenleg -=osszeg;
                Console.WriteLine($"Kifizetés: {osszeg} Ft. Új egyenleg: {egyenleg} Ft.");
            }
            else
            {
                Console.WriteLine("A kifizetés összege nem lehet negatív vagy nagyobb, mint az egyenleg.");
            }
        }
    }
}
