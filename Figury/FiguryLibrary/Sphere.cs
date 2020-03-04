using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Sphere : Circle
    {
        public Sphere(double r = 1) : base (r)
        {
           

        }

        public override string ToString()
        {
            return $"sphere({R})";
        }
        public override double Surface => 4 * base.Surface;   // przykrywać możemy tylko wirtualne wartosci. gdy dajemy new to piszemy ten kod od zera zrywamy z wczesniejsza definicja

        public new double Perimeter => throw new NotSupportedException("sfera nie ma obwodu");

        public new Sphere Scale(double factor)
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException("bla bla bla");
            return new Sphere(R * factor);

        }
    }
}
