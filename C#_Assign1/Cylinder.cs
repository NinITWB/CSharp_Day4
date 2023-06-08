namespace Task1
{
    class Cylinder : Circle
    {
        const double PI = MathF.PI;
        private float height;

        public float Height
        {
            get {return this.height;}
            set {this.height = value;}
        }

        public Cylinder()
        {
            color = "White";
        }

        public override double Area()
        {
            return Math.Round(2 * PI * radius * this.height + 2 * PI * MathF.Pow(radius, 2), 3);
        }

        public double Volume()
        {
            return Math.Round(PI * Math.Pow(radius, 2) * this.height, 3);
        }

        public override string ToString()
        {
            return $"Radius: {radius}, color: {color}, height: {this.height}";
;
        }
    }
}