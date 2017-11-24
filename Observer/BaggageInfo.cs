namespace Observer
{
    public class BaggageInfo
{
   internal BaggageInfo(int flight, string from, int carousel)
   {
      FlightNumber = flight;
      From = from;
      Carousel = carousel;
   }

   public int FlightNumber { get; }

   public string From { get; }

   public int Carousel { get; }
}
}