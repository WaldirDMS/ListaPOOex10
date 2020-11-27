using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOOex10
{
    class Retangulo
    {
        private int b;
        private int h;
        private int a;

        public void setBase(int p)
        {
            b = p;
        }

        public void setAltura(int p)
        {
            h = p;
        }

        public int getBase()
        {
            return b;
        }

        public int getAltura()
        {
            return h;
        }

        public int getArea()
        {
            return a;
        }

        public void calcularArea()
        {
            a = b * h;

            if (a > 100)
    {
                Console.WriteLine("Terreno grande");
            }

            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }

        

    }

}
