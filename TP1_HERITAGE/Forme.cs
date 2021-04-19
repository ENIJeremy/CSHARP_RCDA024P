using System;
using System.Text;

namespace TP1_HERITAGE
{
    internal abstract class Forme
    {
        protected StringBuilder m_StringBuilder = new StringBuilder();


        protected abstract double getAire();
        protected abstract double getPerimeter();


        public override string ToString()
        {
            m_StringBuilder.AppendLine($"Aire = {getAire()}");
            m_StringBuilder.AppendLine($"Périmètre = {getPerimeter()}");
            return m_StringBuilder.ToString();
        }

    }

    class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override string ToString()
        {
            m_StringBuilder.AppendLine($"Cercle de rayon {Rayon}");
            return base.ToString();
        }

        protected override double getAire()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }

        protected override double getPerimeter()
        {
            return 2 * Rayon * Math.PI;
        }


    }

    class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override string ToString()
        {
            m_StringBuilder.AppendLine($"Rectangle de longueur={Longueur} et largeur={Largeur}");
            return base.ToString();
        }

        protected override double getAire()
        {
            return Largeur * Longueur;
        }

        protected override double getPerimeter()
        {
            return (Largeur + Longueur) * 2;
        }
    } 
    
    class Carre : Forme
    {
        public int Longueur { get; set; }

        public override string ToString()
        {
            m_StringBuilder.AppendLine($"Carré de coté={Longueur}");
            return base.ToString();
        }

        protected override double getAire()
        {
            return Math.Pow(Longueur, 2);
        }

        protected override double getPerimeter()
        {
            return Longueur * 4;
        }
    } 
    
    class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override string ToString()
        {
            m_StringBuilder.AppendLine($"Triangle de coté A={A}, A={B}, A={C}");
            return base.ToString();
        }

        protected override double getAire()
        {
            double p = getPerimeter() / 2;

            return Math.Sqrt(p*(p - A)*(p - B)*(p - C));

           
        }

        protected override double getPerimeter()
        {
            return A + B + C;
        }
    }
}