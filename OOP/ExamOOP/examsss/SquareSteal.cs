using System;
using System.Collections.Generic;
using System.Text;

namespace examsss
{
    class SquareSteal : PowerSteal
    {
        private int side;
        public SquareSteal(int thickness, double density, int side) : base(thickness, density) {
           this.side = side;
                }

        public override double Square()
        {
            return side * side;
        }
        public override double Weight()
        {
            return base.Weight();
        }
        public override string Information()
        {
            return "Квадратний лист: Товщина - " + thickness + " густина:" + density;
        }
        

    }
}
