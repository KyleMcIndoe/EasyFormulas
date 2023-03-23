public static class conversions {
    public static double toRadians(double degrees) {
        return degrees / 180;
    }

    public static double toDegrees(double radians) {
        return radians * 180;
    }

    public static double celciusToKelvin(double celcius) {
        return celcius + 273;
    }

    public static double celciusToFarenheit(double celcius) {
        return 1.8 * celcius + 32;
    }

    public static double kelvinToCelcius(double kelvin) {
        return kelvin - 273;
    }

    public static double kelvinToFarenheit(double kelvin) {
        return celciusToFarenheit(kelvinToCelcius(kelvin));
    }

    public static double farenheitToCelcius(double farenheit) {
        return (farenheit - 32) / 1.8;
    }

    public static double farenheitToKelvin(double farenheit) {
        return celciusToKelvin(farenheitToCelcius(farenheit));
    }

}