namespace mathStatistics;
public class statisticsFormulas 
{
    public static double sumOfDataset (double[] arr) {
        double sum = 0;
        for(int i = 0; i < arr.Length; i++) sum += arr[i];
        return sum;
    }
}