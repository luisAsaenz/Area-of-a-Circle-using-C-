using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {

            double pI = Math.PI;

            double r;
            r = Convert.ToDouble(Console.ReadLine());

            if (r > 0)
            {
                r = Math.Pow(r , 2);
                double area = r * pI;
                Console.WriteLine("The Area is: " + area);
            }

        }
    }
}
