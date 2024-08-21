// Inflation.cs

public class Inflation
{
    public string RegionalMember { get; set; }
    public int Year { get; set; }
    public double InflationRate { get; set; }
    public string UnitOfMeasurement { get; set; }
    public string Subregion { get; set; }
    public string CountryCode { get; set; }

    public Inflation(string regionalMember, int year, double inflationRate, string unitOfMeasurement, string subregion, string countryCode)
    {
        RegionalMember = regionalMember;
        Year = year;
        InflationRate = inflationRate;
        UnitOfMeasurement = unitOfMeasurement;
        Subregion = subregion;
        CountryCode = countryCode;
    }
}
