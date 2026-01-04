namespace OfferCalculator;

class PassengerInfo
{
    public DateOnly DateOfBirth { get; }
    public DateOnly DateOfFlight { get; }
    public bool IsDomesticFlight { get; }
    public bool IsRegularCustomer { get; }
    public bool IsBaby { get; }
    public bool IsAdolescense { get; }
    public bool IsAdult { get; }
    public bool IsSeasonalFlight { get; }
    public bool IsBoughtInAdvance { get; }

    public PassengerInfo(
        DateOnly dateOfBirth,
        DateOnly dateOfFlight,
        bool isDomesticFlight,
        bool isRegularCustomer,
        DatesVerificator datesVerifier
    )
    {
        DateOfBirth = dateOfBirth;
        DateOfFlight = dateOfFlight;
        IsDomesticFlight = isDomesticFlight;
        IsRegularCustomer = datesVerifier.IsAdult(dateOfBirth) ? isRegularCustomer : false;
        IsBaby = datesVerifier.IsBaby(dateOfBirth);
        IsAdolescense = datesVerifier.IsAdolescense(dateOfBirth);
        IsAdult = datesVerifier.IsAdult(dateOfBirth);
        IsSeasonalFlight = datesVerifier.IsSeasonal(dateOfFlight);
        IsBoughtInAdvance = datesVerifier.IsBoughtInAdvance(dateOfFlight);
    }
}
