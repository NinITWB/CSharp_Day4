namespace Task1
{
    class Circle 
    {
        const double PI = Math.PI;
        protected float radius;
        public float Radius
        {
            get {return this.radius;}
            set {this.radius = value;}
        }
        protected string color;
        public string Color
        {
            get {return this.color;}
            set {this.color = value;}
        }

        public Circle()
        {
            this.color = "Gray";
        }

        public virtual double Area()
        {
            
            return Math.Round(PI * MathF.Pow(this.radius, 2), 3);

        }

        public override string ToString()
        {
            return $"Radius: {this.radius}, color: {this.color}";
        }
    }
}