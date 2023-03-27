public static class quadratics {
    public static double[] quadraticFormula(double a, double b, double c) {
        double discriminant = (b * b) - 4 * a * c; // returns a two digit array of both possible values
        double[] ans = {(-b + Math.Sqrt(discriminant)) / (2 * a), (-b - Math.Sqrt(discriminant)) / (2 * a)};
        return ans;
    }
}