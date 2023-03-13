namespace mathStatistics;
public class datasetFormulas 
{
    public static double sumOfDataset (double[] arr) {
        double sum = 0;
        for(int i = 0; i < arr.Length; i++) sum += arr[i];
        return sum;
    }

    public static double findMedian(double[] arr) {
        if(arr.Length % 2 == 0) return (arr[arr.Length / 2] + arr[(arr.Length / 2) - 1]) / 2;
        return arr[Convert.ToInt16((arr.Length / 2) - 0.5)];
    }
    
}