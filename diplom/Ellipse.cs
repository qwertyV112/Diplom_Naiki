using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom
{
    class Ellipse
    {
        public double x;
        public double y;
        public double x1;
        public double y1;
        public double Radiys;
        private Pen pen;
        private Graphics Object;
        public Ellipse(Graphics image,double middleX, double middleY)
        {
            this.Object = image;
            x1 = middleX / 2;
            y1 = middleY / 2;
            pen = new Pen(Color.Red);
            this.Render();
        }
        public void Clear()
        {

        }
        public void Render() // рисует круг с данными параметраммм
        {
            this.Object.DrawLine(pen, 10, 10, 51, 51);
           // Object.
        }
    }
}
