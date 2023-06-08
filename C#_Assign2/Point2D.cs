namespace Task2
{
    class Point2D
    {
        protected float x;
        public float X
        {
            get {return this.x;}
            set {this.x = value;}
        }

        protected float y;
        public float Y
        {
            get {return this.y;}
            set {this.y = value;}
        }

        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float[] GetXY()
        {
            float[] arrPoint2D = {this.x, this.y};
            return arrPoint2D;
        }

        public Point2D() {}
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"The Point2D: ({this.x}, {this.y})";
        }


    }
}