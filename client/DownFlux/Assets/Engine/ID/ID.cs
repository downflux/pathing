namespace DF.Game.ID
{
    public class Tick : System.IComparable
    {
        private double _tick;
        public Tick(double t) { Double = t; }
        public Tick(Tick t) : this(t.Double) { }
        public double Double
        {
            get => _tick;
            private set { _tick = value; }
        }

        public int CompareTo(object other)
        {
            var v = other as Tick;
            return Double.CompareTo(v.Double);
        }

        public override bool Equals(object obj)
        {
            return Double.Equals((obj as Tick).Double);
        }

        public override int GetHashCode()
        {
            return Double.GetHashCode();
        }

        public static Tick operator -(Tick a, Tick b) { return new Tick(a.Double - b.Double); }
        public static bool operator <(Tick a, Tick b) { return a.Double < b.Double; }
        public static bool operator >(Tick a, Tick b) { return a.Double > b.Double; }

        public static bool operator >=(Tick a, Tick b) { return a.Double >= b.Double; }
        public static bool operator <=(Tick a, Tick b) { return a.Double <= b.Double; }
    }

    public class ID
    {
        private string _id;
        public string String
        {
            get => _id;
            private set { _id = value; }
        }

        public ID(string id) { String = id; }

        public static bool operator ==(ID a, ID b) { return a.String == b.String; }
        public static bool operator !=(ID a, ID b) { return a.String != b.String; }

        public override bool Equals(object obj)
        {
            return String.Equals((obj as ID).String);
        }

        public override int GetHashCode()
        {
            return String.GetHashCode();
        }
    }

    public class EntityID : ID
    {
        public EntityID(string id) : base(id) { }
    }
}