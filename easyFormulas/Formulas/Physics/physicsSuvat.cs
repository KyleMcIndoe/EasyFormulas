
public static class suvatFormulas
{
    public static class withoutDisplacement { // Find initial velocity, final velocity, acceleration and time without displacement
        public static double uwithouts(double v, double a, double t) {
            return v - (a * t);
        }

        public static double vwithouts(double u, double a, double t) {
            return u + (a * t);
        }

        public static double awithouts(double v, double u, double t) {
            return (v - u) / t;
        }

        public static double twithouts(double v, double u, double a) {
            return (v - u) / a;
        }
    }
    public static class withoutInitialVelocity { // Find displacement, final velocity, acceleration and time without initial velocity
        public static double swithoutu(double v, double a, double t) {
            return (v * t) - (0.5 * a * (t * t));
        }
        
        public static double vwithoutu(double s, double a, double t) {
            return (s + (a * (t * t))) / (2 * t);
        }
        
        public static double awithoutu(double s, double v, double t) {
            return (2 * (v * t - s)) / (t * t);
        }
        
        public static double twithoutu(double s, double v, double a) {
            return (v - Math.Sqrt((v * v) - 2 * a * s)) / a;
        }
    }
    public static class withoutFinalVelocity { // Find displacement, initial velocity, acceleration and time without final velocity
        public static double swithoutv(double u, double a, double t) {
            return (u * t) + (0.5 * a * (t * t));
        }

        public static double uwithoutv(double s, double a, double t) {
            return (s - (a * (t * t))) / (2 * t);
        }

        public static double awithoutv(double s, double u, double t) {
            return (2 * (s - (u * t))) / (t * t);
        }

        public static double twithoutv(double s, double u, double a) {
            return (Math.Sqrt(2 * a * s + (u * u)) - u) / a;
        }
    }
    public static class withoutAcceleration { // Find displacement, initial velocity, final velocity and time without acceleration
        public static double swithouta(double u, double v, double t) {
            return (t / 2) * (u + v);
        }

        public static double uwithouta(double s, double v, double t) {
            return (2 * s / t) + v;
        }

        public static double vwithouta(double s, double u, double t) {
            return 2 * s / t - u;
        }

        public static double twithouta(double s, double u, double v) {
            return (2 * s) / (u + v);
        }
    }
    public static class withoutTime { // Find displacement, initial velocity, final velocity and acceleration without time
        public static double swithoutt(double u, double v, double a) {
            return ((u * u) + (v * v)) / (2 * a);
        }

        public static double uwithoutt(double s, double v, double a) {
            return Math.Sqrt((2 * a * s) - (v * v));
        }

        public static double vwithoutt(double s, double u, double a) {
            return Math.Sqrt((u * u) + (2 * a * s));
        }

        public static double awithoutt(double s, double u, double v) {
            return ((v * v) - (u * u)) / (2 * s);
        }
    }
}




