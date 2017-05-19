using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonablePoint
{
    class Point:ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public Point (int xPos,int yPos,string petName)
        {
            X = xPos;
            Y = xPos;
            desc.PetName = petName;
        }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = xPos;
        }
        public Point() { }
        public override string ToString()
        {
            return string.Format("X = {0}: Y={1}: Name= {2};\nID ={3}\n",X,Y,desc.PetName,desc.PointID);
        }

        public object Clone()
        {
            Point newPoint= (Point)this.MemberwiseClone();
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;


        }
    }
}
