using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _24._19
{
    internal class Vector
    {
        private readonly float x;
        private readonly float y;

        public float X { get{ return x; } }
        public float Y { get { return y; } }

        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X+b.X, a.Y+b.Y);
        }

        public override string ToString()
        {
            return string.Format("{0};{1}", x, y);
        }

        //19.20

        public static Vector operator +(Vector v)
        {
            return new Vector(v.x, v.y);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(v.y, v.x);
        }

        public static Vector operator-(Vector a, Vector b)
        {
            return new Vector(a.X-b.X, a.Y-b.Y);
        }

        //metodi richiesti per mail

        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.x*b.x, a.y*b.y);
        }

        public static Vector operator *(float a, Vector b)
        {
            return new Vector(a*b.x, a*b.y);
        }

        public static Vector Parse(string s)
        {
            string[] strings = s.Split(';');
            return new Vector(float.Parse(strings[0]), float.Parse(strings[1]));
        }

        
    }
}
