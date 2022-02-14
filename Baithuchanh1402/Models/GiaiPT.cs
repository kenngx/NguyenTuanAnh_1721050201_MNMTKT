using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GiaiPT
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public GiaiPT()
        {
            a = 0;
            b = 0;
            c = 0;
            x1 = 0;
            x2 = 0;
        }
        public GiaiPT(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.x1 = 0;
            this.x2 = 0;
        }
        public void Giai()
        {
            if (a == 0)
            {
                x1 = -c / b;
                x2 = 0;
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    x1 = 0;
                    x2 = 0;
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = 0;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                }
            }
        }
    }
}
namespace GiaiPT
{
    class GiaiPT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so b: ");
            double b = double.Parse(Console.ReadLine());
            double x;
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem duy nhat: {0}", -b);
                }
            }
            else
            {
                x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem duy nhat: {0}", x);
            }
        }
    }
}
