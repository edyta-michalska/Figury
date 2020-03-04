using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{

    /// <summary>
    /// Trojkat w wersji immutable
    /// </summary>
    public class Trianle : Figure
    {
        public double A { get; private set; } //A jest read only
        public double B { get; private set; }
        public double C { get; private set; }

        public Trianle(double a = 1, double b = 1, double c = 1) : base ("read")
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("boki powinny być dodatnie");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("nie spełniony warunek trojkata");
            A = a;
            B = b;
            C = c;
        }


            public override string ToString()
            {
            return $"trianle({A}, {B}, {C})";
            }
        public double Perimeter => A + B + C;


        public Trianle Scale( double factor)
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException("wspolczynnik skalowania musi być dodatki");

            return new Trianle(A * factor, B * factor, C * factor);

        }

        public override void Draw()
        {
            Console.WriteLine("rysowanie trojkata");
        }
    }

    
}
