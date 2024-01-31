using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangolo
    {
        public int lato1 {  get; set; }
        public int lato2 { get; set; }
        public int lato3 { get; set;}

        public string checkTriangolo()
        {
            if(lato1 == lato2 && lato2 == lato3)
            {
                return "Il triangolo e' equilatero";
            }
            else if(lato1 == lato2 || lato1 == lato3 || lato2 == lato3)
            {
                return "Il triangolo e' isoscele";
            }
            else
            {
                return "Il triangolo e' scaleno";
            }
        }

        public Triangolo(int lato1, int lato2, int lato3)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;
            this.lato3 = lato3;
        }

        public string latoPiuLungo()
        {
            if (lato1 > lato2 && lato1 > lato3)
            {
                return "Il lato piu' lungo e' " + lato1;
            }
            else if (lato2 > lato3 && lato2 > lato1)
            {
                return "Il lato piu' lungo e' " + lato2;
            }
            else
            {
                return "Il lato piu' lungo e' " + lato3;
            }
        }
    }
}
