namespace DPcode.Domain
{
    public interface IWheatherChecker
    {
        int ContainsCloudBurst(double[] arrayOfRain);

        int ContainsHeavyRain(double[] arrayOfRain);
        int ContainsVeryHeavyRain(double[] arrayOfRain);
    }
}