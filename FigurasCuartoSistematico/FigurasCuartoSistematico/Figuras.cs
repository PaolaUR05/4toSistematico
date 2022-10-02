using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasCuartoSistematico
{
    internal class Figuras : Object
    {
        private double area; 

        public Figuras(double area)
        {
            this.area = area;
        } 
        
        public double Area
        {
            get { return area; }
           
        }
    }
}
