namespace Task2
{
    class Point3D : Point2D
    {
        private float z;
        public float Z
        {
            get {return this.z;}
            set {this.z = value;}
        }

        public void SetXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float[] GetXYZ()
        {
            float[] arrPoint3D = {x, y, this.z};
            return arrPoint3D;
        }

        public Point3D() {this.z = 0f;}

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }

        public override string ToString()
        {
            return $"The Point3D: ({x}, {y}, {this.z})";
        }
    }
}