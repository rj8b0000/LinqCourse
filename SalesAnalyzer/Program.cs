using SalesAnalyzer.Models;

namespace SalesAnalyzer
{ 
    class Program 
    {
        public static void Main(string[] args)
          {
              //Read a CSV file and parse each line into a strongly-typed object.
              var lines = File.ReadAllLines("sales.csv").Skip(1);
              
              var records = lines.Select(line =>
              {
                var parts = line.Split(',');
              
                return new SalesRecord
                {
                  Id = int.Parse(parts[0]),
                  Product = parts[1],
                  Region = parts[2],
                  Sales = decimal.Parse(parts[3]),
                  Date = DateTime.Parse(parts[4])
                };
              }).ToList();
              
              // foreach (var record in records)
              // {
              //   Console.WriteLine($"{record.Id},{record.Product},{record.Region},{record.Sales}");
              // }
              
              
              //Filter records based on criteria (e.g., sales > 1000, region = "North").
              var filtered = records
                  .Where(r => r.Sales > 1000 && r.Region == "North")
                  .ToList();
              // foreach (var record in filtered)
              // {
              //     Console.WriteLine($"{record.Id},{record.Product},{record.Region},{record.Sales}");
              // }
              
              //Group records by a category (e.g., region, product type) and compute aggregates.
              // var regionSummary = records
              //     .GroupBy(r => r.Region)
              //     .Select(group => new
              //     {
              //         Region = group.Key,
              //         Count = group.Count(),
              //         TotalSales = group.Sum(x => x.Sales),
              //         AverageSales = group.Average(x => x.Sales)
              //     })
              //     .ToList();
              //       foreach (var region in regionSummary)
              //       {
              //           Console.WriteLine($"Region: {region.Region} Count: {region.Count}  Sales : {region.TotalSales} Average Sales : {region.AverageSales:F2}");
              //       }
              
              //Find duplicates using GroupBy + Where(g => g.Count() > 1).
              // var duplicates = records
              //     .GroupBy(r => new { r.Product, r.Region })
              //     .Where(g => g.Count() > 1)
              //     .SelectMany(g => g)
              //     .ToList();
              //
              // foreach (var duplicate in duplicates)
              // {
              //     Console.WriteLine($"{duplicate.Id},{duplicate.Region},{duplicate.Sales},{duplicate.Date}");
              // }
              
              //5. Export results** to a new list or display as a formatted report.
              // var highValueSales = records
              //     .Select(r => new
              //     {
              //         r.Product,
              //         r.Region,
              //         r.Sales,
              //         r.Date
              //     })
              //     .ToList();
              // foreach (var record in highValueSales)
              // {
              //     Console.WriteLine($"{record.Product} {record.Region} {record.Sales} {record.Date}");
              // }
          }
      }
}