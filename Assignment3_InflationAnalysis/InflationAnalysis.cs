// InflationAnalysis.cs

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class InflationAnalysis
{
    private List<Inflation> AsianPacificInflation;

    public InflationAnalysis()
    {
        AsianPacificInflation = new List<Inflation>();
    }

    public void ReadInflationData(string filePath)
    {
        try
        {
            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine(); // Skip header line
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        Console.WriteLine("Empty line found. Skipping.");
                        continue;
                    }

                    string[] values = line.Split(',');

                    if (values.Length < 6)
                    {
                        Console.WriteLine($"Invalid line format: '{line}'. Skipping.");
                        continue;
                    }

                    if (int.TryParse(values[1], out int year) &&
                        double.TryParse(values[2].Replace("%", ""), NumberStyles.Number, CultureInfo.InvariantCulture, out double inflationRate))
                    {
                        Inflation inflationData = new Inflation(
                            regionalMember: values[0],
                            year: year,
                            inflationRate: inflationRate,
                            unitOfMeasurement: values[3],
                            subregion: values[4],
                            countryCode: values[5]
                        );
                        AsianPacificInflation.Add(inflationData);
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing data in line: {line}. Skipping this line.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the CSV file: {ex.Message}");
        }
    }

    public List<Inflation> GetInflationRatesForYear(int year)
    {
        return AsianPacificInflation.Where(inflation => inflation.Year == year).ToList();
    }

    public int GetYearWithHighestInflationForCountry(string countryName)
    {
        return AsianPacificInflation
            .Where(inflation => inflation.RegionalMember == countryName)
            .OrderByDescending(inflation => inflation.InflationRate)
            .Select(inflation => inflation.Year)
            .FirstOrDefault();
    }

    public List<Inflation> GetTop10RegionsWithHighestInflation()
    {
        return AsianPacificInflation
            .GroupBy(inflation => inflation.RegionalMember)
            .Select(group => new Inflation(
                regionalMember: group.Key,
                year: 0,
                inflationRate: group.Average(inflation => inflation.InflationRate),
                unitOfMeasurement: "",
                subregion: "",
                countryCode: ""
            ))
            .OrderByDescending(inflation => inflation.InflationRate)
            .Take(10)
            .ToList();
    }

    public List<Inflation> GetTop3SouthAsianCountriesWithLowestInflationForYear(int year)
    {
        return AsianPacificInflation
            .Where(inflation => inflation.Year == year && inflation.Subregion == "South Asia")
            .OrderBy(inflation => inflation.InflationRate)
            .Take(3)
            .ToList();
    }
}
