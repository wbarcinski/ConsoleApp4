using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.BegCShCollections.TopTenPops
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"C:\cs\pluralsight\csharp-collections-beginning\Pop by Largest Final.csv";
			CsvReader reader = new CsvReader(filePath);

			List<Country> countries = reader.ReadAllCountries();
			Country lilliput = new Country("Liliput","LIL","Somwhere",2000000);
			int lilliputIndex = countries.FindIndex(country=>country.Population < 2000000);
			countries.Insert(lilliputIndex, lilliput);

			foreach (Country country in countries)
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}
            Console.WriteLine($"Total Countries count is: {countries.Count}");
			Console.ReadKey();
		}
	}
}
