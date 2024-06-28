using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_T
{
    public class Geometry
    {
        public int CalculateArea(int a, int b)
        {
            return a * b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry geometry = new Geometry();
            int area = geometry.CalculateArea(-4, 10);
            Console.WriteLine("Площадь: " + area);
        }
    }
}
