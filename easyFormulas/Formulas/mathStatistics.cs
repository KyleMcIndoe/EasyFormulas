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

    public static double findRange(double[] arr) {
        return arr[arr.Length - 1] - arr[0];
    }

    public static double findIQR(double[] arr) {
        int splitIndex = 0;
        if(arr.Length % 2 == 0) splitIndex = arr.Length / 2;
        if(arr.Length % 2 != 0) splitIndex = Convert.ToInt16((arr.Length / 2) - 0.5);
        double[] subArrayOne = new double[splitIndex];
        double[] subArrayTwo = new double[arr.Length - splitIndex];
        for(int i = 0; i < splitIndex; i++) subArrayOne[i] = arr[i];
        for(int i = splitIndex; i < arr.Length; i++) subArrayTwo[i] = arr[i];
        return findMedian(subArrayTwo) - findMedian(subArrayOne);
    }
}