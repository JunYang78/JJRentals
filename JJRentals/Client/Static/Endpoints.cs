namespace JJRentals.Client.Static
{

    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MakesEndpoint = $"{Prefix}/manus";
        public static readonly string ModelsEndpoint = $"{Prefix}/models";
        public static readonly string ColoursEndpoint = $"{Prefix}/colours";
        public static readonly string carsEndpoint = $"{Prefix}/cars";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
    }


}
