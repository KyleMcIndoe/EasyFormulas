public static class circleFormulas{
    public static double area(double radius) {
        return constants.pi * (radius * radius);
    }

    public static double circumference(double radius) {
        return 2 * constants.pi * radius;
    }

    public static double radiusFromArea(double area) {
        return Math.Sqrt(area / constants.pi);
    }

    public static double radiusFromCircumference(double circ) {
        return circ / 2 / constants.pi;
    }

    public static double diameter(double radius) {
        return 2 * radius;
    }

    public static double lengthOfArc(double angle, double radius) {
        return (angle / 360) * circumference(radius);
    }

    public static double areaOfSector(double angle, double radius) {
        return (angle / 360) * area(radius);
    }
}

public static class rightTriangleFormulas{
    public static double hypoteneuse(double a, double b) {
        return Math.Sqrt((a * a) + (b * b));
    }

    public static double area(double length, double width) {
        return 0.5 * (length * width);
    }
}

public static class triangleFormulas{
    public static double area(double a, double b, double angleC) {
        return 0.5 * a * b * Math.Sin(angleC);
    }

    public static double sineRuleForLength(double a, double anglea, double angleb) {
        return Math.Sin(angleb) * (a / Math.Sin(anglea));
    }

    public static double sineRuleForAngle(double a, double anglea, double b) {
        return Math.Asin(b / (a / anglea)); // this one might be wrong
    }

    public static double cosineRuleForHypoteneuse(double a, double b, double anglec) {
        return Math.Sqrt((a * a) + (b * b) - 2 * a * b * Math.Cos(anglec));
    }

    public static double cosineRuleForAngle(double a, double b, double c) {
        return ((a * a) + (b * b) - (c * c)) / (2 * a * b);
    }
}

public static class parrallelogram {
    public static double area(double bbase, double height) { // base is spelled bbase because base is a c# keyword
        return bbase * height;
    }
}