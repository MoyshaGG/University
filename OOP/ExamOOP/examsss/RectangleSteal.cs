using System;
using System.Collections.Generic;
using System.Text;

namespace examsss
{
    class RectangleSteal : PowerSteal
    {
        private int height;
        private int width;
        
        public RectangleSteal(int thickness, double density, int height, int width) : base(thickness, density)
        {
            this.height = height;
            this.width = width;
        }

        public override double Square()
        {
            return height * width;
        }
        public override double Weight()
        {
            return base.Weight();
        }
        public override string Information()
        {
            return "Прямокутний лист: Товщина - " + thickness + " густина:" + density;
        }
    }
}
