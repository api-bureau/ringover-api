namespace ApiBureau.Ringover.Api.Queries;

public sealed record TranscriptQuery(
    DateTime? CreatedFrom,
    DateTime? CreatedTo,
    int? Limit = 1000,
    int? Offset = 0);