namespace ConsoleApplication1.ass1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TrendSetting trendSetting = new TrendSetting();
            trendSetting.Sales();
            ClimateControl climateControl = new ClimateControl();
            climateControl.Materials();
            Sports sp = new Sports();
            climateControl.CommonWear();
        }
    }
}