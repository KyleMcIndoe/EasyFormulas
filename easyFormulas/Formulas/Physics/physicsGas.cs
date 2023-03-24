public static class idealGasPhysics {
    public static double findPressure(double v, double n, double t) {
        return (n * constants.gasConstant * t) / v;
    }

    public static double findVolume(double p, double n, double t) {
        return (n * constants.gasConstant * t) / p;
    }

    public static double findMoles(double p, double v, double t) {
        return (p * v) / t / constants.gasConstant; 
    }

    public static double findTempChange(double p, double b, double n) {
        return (p * b) / n / constants.gasConstant;
    }
}