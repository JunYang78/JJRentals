namespace JJRentals.Client.Static
{

    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ManufacturersEndpoint = $"{Prefix}/manufacturers";
        public static readonly string ModelsEndpoint = $"{Prefix}/models";
        public static readonly string carsEndpoint = $"{Prefix}/cars";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly string PaymentsEndpoint = $"{Prefix}/payments";
    }


}
