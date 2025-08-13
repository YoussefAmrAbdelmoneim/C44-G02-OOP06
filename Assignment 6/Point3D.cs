namespace Assignment_6
{
    internal class Point3D :IComparable<Point3D>,ICloneable
    {
        private int x;
        private int y;
        private int z;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D() : this(0, 0, 0) { }
        public int CompareTo(Point3D? point)
        {
            if (this.x != point?.x)
                return this.x.CompareTo(point?.x);
            return this.y.CompareTo(point?.y);
        }

        public static bool operator ==(Point3D left,Point3D right)
        {
            if (left.x == right.x && left.y == right.y && left.z == right.z)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            if (left.x != right.x && left.y != right.y && left.z != right.z)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x},{y},{z})";
        }

        public object Clone()
        {
            return new Point3D(x, y, z);
        }
    }
}
