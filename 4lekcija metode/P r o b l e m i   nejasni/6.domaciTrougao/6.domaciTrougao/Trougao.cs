using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.domaciTrougao
{
    internal class Trougao
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public Trougao()
        {

        }
        public Trougao(int a)
        {
            this.a = a;
        }
        public Trougao (int a, int b)
        {
            this.a = a; 
            this.b = b;
        }

        public Trougao(int a, int b, int c)
        {
            this.a = a; 
            this.b = b;
            this.c = c;
        }

        public  double Povrsina(int a)
        {
            double pov = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
            return pov;
        }

        public  double Povrsina(int a, int b)
        {
            double ha = Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2) / 4);
            double pov = a * ha / 2;
            return pov;
        }
        public double Povrsina(int a, int b,int c)
        {
            
            double pov = a * b * c;
            return pov;
        }
    }
}
