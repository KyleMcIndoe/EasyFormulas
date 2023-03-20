
public class fraction{
    public int numerator;
    public int denominator;
    public fraction(int numer, int denom) {
        numerator = numer;
        denominator = denom;
    }
}

public static class fractionFormulas {
    public static decimal toDecimal(fraction F) {
        return F.numerator / F.denominator;
    }

    public static double toDouble(fraction F) {
        return F.numerator / F.denominator;
    }
    
    public static float toFloat (fraction F) {
        return F.numerator / F.denominator;
    }

    public static string toPercent (fraction F) {
        return ("%" + toDecimal(F));
    }

}