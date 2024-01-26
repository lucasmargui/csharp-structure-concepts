using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{

    abstract class Shape
    {
        public const double pi = Math.PI;
        protected double x, y;

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Essas assinaturas especificam os parâmetros e o valor retornado, mas não têm nenhuma implementação (corpo do método)
        public abstract double Area();
    }
}
