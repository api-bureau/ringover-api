namespace ApiBureau.Ringover.Api.Queries;

public sealed record CallQuery(
    DateTime? StartDate,
    DateTime? EndDate,
    int? Limit = 1000,
    int? Offset = 0);