public static class cuboid {
    public static double volume(double l, double h, double w) {
        return l * h * w;
    }

    public static double surfaceArea(double l, double h, double w) {
        return (2 * l * w) + (2 * l * h) + (2 * h * w);
    }
}

public static class cylinder {
    public static double volume(double radius, double height) {
        return circleFormulas.area(radius) * height;
    }

    public static double areaOfCurvedPart(double radius, double height) {
        return 2 * constants.pi * radius * height;
    }

    public static double surfaceArea(double radius, double height) {
        return (2 * circleFormulas.area(radius)) + areaOfCurvedPart(radius, height);
    }
}