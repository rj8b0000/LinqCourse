namespace SalesAnalyzer.Models;

public class SalesRecord
{
    public int Id { get; set; }
    public string Product { get; set; }
    public string Region { get; set; }
    public decimal Sales { get; set; }
    public DateTime Date { get; set; }
}
