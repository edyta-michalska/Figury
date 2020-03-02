using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        //dane obiektu - pola obiektu (fields)
        private double a; //this.a

        public double A
        {
            get { return a; }
            set
            { if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość A musi być dodatnia");
                else
                    a = value;
            }

        }
        private double b;// this.b

        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość B musi być dodatnia");
                else
                    b = value;
            }
        }
        private double c; //this.c
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość C musi być dodatnia");
                else
                    c = value;

            }
        }



        //konstruktory
        public Trojkat()  //konstruktor domyslny
        {
            a = b = c = 1.0;
        }

        public Trojkat(double a, double b, double c)
        {

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("mie spełniony warunek trojkata");
            }

            this.A = a;
            this.B = b;
            this.C = c;


        }
        //testowa reprezentacja obiektu
        public override string ToString()
        {
            return $"trójkąt(a: {a},b: {b},c: {c})";
        }

        //wlasciwosci i metody

        public double GetObwod() //metoda zwracajaca obwod tego trojkata
        {
            return a + b + c;
        }
        //property zwracajace obwod tego trokata
        public double Obwod => a + b + c;

        public double GetPole() //jawa style
        {
            var p = 0.5 * GetObwod();
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;


        }
        public double Pole
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;

            }


        }
    }
    
}
