using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_c_sharp
{
    class Vector
    {
        double x;
        double y;
        double z;

        public Vector()
        {
        }

        //Перегрузка оператора сложения 2х векторов
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
        //Перегрузка оператора умножения вектора на скаляр
        public static Vector operator *(Vector v1, int scalar)
        {
            return new Vector(v1.x * scalar, v1.y * scalar, v1.z * scalar);
        }
        //Перегрузка оператора векторного умножения 2х векторов
        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }

        public double ScalarProduct(Vector v1, Vector v2)
        {
            return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
        }

        public override string ToString()
        {
            return "(" + x + "; " + y + "; " + z + ") ";
        }


        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
    }
}
