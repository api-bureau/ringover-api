namespace ApiBureau.Ringover.Api.Dtos;

public class PayrollDto
{
    public required string Ein { get; set; }
    public DateTime PayDate { get; set; }
    public DateTime PayrollInitiationDate { get; set; }
    public required string PayrollType { get; set; }
    public required string Status { get; set; }
    public DateTime StatusDate { get; set; }

    //[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public required string PayrollNumber { get; set; }

    public DateTime PayrollStartDate { get; set; }
    public DateTime PayrollEndDate { get; set; }
    public DateTime? CutoffDate { get; set; }
    public required string PayGroup { get; set; }
    public required string PayFrequency { get; set; }
}