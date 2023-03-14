namespace mathProbabilities;

public class probabilityFormulas {
    public static double missingProbability(double[] arr) {
        double ans = 1;
        for(int i = 0; i < arr.Length; i++) {
            ans = ans - arr[i];
        }
        if(ans < 0) {
            throw new Exception("Probabilities do not add up to 1");
        }
        return ans; // returns a missing probability, when inputting a table of other probabilities
    }
}