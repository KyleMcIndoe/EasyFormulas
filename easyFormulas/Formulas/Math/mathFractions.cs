
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
    
    public static fraction add(fraction a, fraction b){
        int commonDenominator = a.denominator * b.denominator;
        a.numerator = a.numerator * (commonDenominator / a.denominator);
        b.numerator = b.numerator * (commonDenominator / b.denominator);
        return new fraction(a.numerator + b.numerator, commonDenominator);
    }

    public static fraction subtract(fraction a, fraction b) {
        int commonDenominator = a.denominator * b.denominator;
        a.numerator = a.numerator * (commonDenominator / a.denominator);
        b.numerator = b.numerator * (commonDenominator / b.denominator);
        return new fraction(a.numerator - b.numerator, commonDenominator);       
    }

    public static fraction multiply(fraction a, fraction b) {
        return new fraction(a.numerator * b.numerator, a.denominator * b.denominator);
    }

    public static fraction divide(fraction a, fraction b) {
        int place = b.numerator;
        b.numerator = b.denominator;
        b.denominator = place;
        return multiply(a, b);
    }
}