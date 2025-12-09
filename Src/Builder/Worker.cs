namespace Builder
{
    public static class Worker
    {
        //Tips for easier chaining
        static IVehicleBuilder AddOption(this IVehicleBuilder builder)
        {
            if (builder is IPremiumVehicleBuilder premiumVehicle)
                premiumVehicle.AddOptions();
            return builder;
        }

        public static Vehicle PrepareVehicule(IVehicleBuilder builder)
        {
            return builder.AddOption().AddEngine().AddSeats().Build();
        }
    }
}
