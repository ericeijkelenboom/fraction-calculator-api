namespace FractionCalculator.Entity
{
    public class Fraction
    {
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; set; }
        public int Denominator { get; set; }

        #region Override equality members

        public bool Equals(Fraction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Numerator == Numerator && other.Denominator == Denominator;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Fraction)) return false;
            return Equals((Fraction)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Numerator * 397) ^ Denominator;
            }
        }

        public static bool operator ==(Fraction left, Fraction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Fraction left, Fraction right)
        {
            return !Equals(left, right);
        }

        #endregion

        #region Override formatting members

        public override string ToString()
        {
            return string.Format("({0}/{1})", Numerator, Denominator);
        }

        #endregion
    }
}