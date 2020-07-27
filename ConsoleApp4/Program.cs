﻿using System;
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

			foreach (Country country in countries)
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}
			Console.ReadKey();
		}
	}
}
