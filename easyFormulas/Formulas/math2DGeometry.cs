public class circleFormulas{
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
}

public class rightTriangleFormulas{
    public static double hypoteneuse(double a, double b) {
        return Math.Sqrt((a * a) + (b * b));
    }

    public static double area(double length, double width) {
        return 0.5 * (length * width);
    }
}

public class triangleFormulas{
    public static double area(double a, double b, double angleC) {
        return 0.5 * a * b * Math.Sin(angleC);
    }

}