using Microsoft.AspNetCore.WebUtilities;
using System.Globalization;

namespace ApiBureau.Ringover.Api.Internals;

internal static class QueryBuilder
{
    internal static string BuildCallQuery(CallQuery query)
    {
        var queryParams = new Dictionary<string, string?>();
        if (query.StartDate.HasValue)
        {
            queryParams["start_date"] = query.StartDate.Value.ToString("o", CultureInfo.InvariantCulture);
        }

        if (query.EndDate.HasValue)
        {
            queryParams["end_date"] = query.EndDate.Value.ToString("o", CultureInfo.InvariantCulture);
        }

        if (query.Limit.HasValue)
        {
            queryParams["limit_count"] = query.Limit.Value.ToString(CultureInfo.InvariantCulture);
        }

        if (query.Offset.HasValue)
        {
            queryParams["limit_offset"] = query.Offset.Value.ToString(CultureInfo.InvariantCulture);
        }

        return QueryHelpers.AddQueryString($"/calls", queryParams);
    }

    internal static string BuildTranscriptQuery(TranscriptQuery query)
    {
        var queryParams = new Dictionary<string, string?>();
        if (query.CreatedFrom.HasValue)
        {
            queryParams["created_from"] = query.CreatedFrom.Value.ToString("o", CultureInfo.InvariantCulture);
        }

        if (query.CreatedTo.HasValue)
        {
            queryParams["created_to"] = query.CreatedTo.Value.ToString("o", CultureInfo.InvariantCulture);
        }

        if (query.Limit.HasValue)
        {
            queryParams["limit_count"] = query.Limit.Value.ToString(CultureInfo.InvariantCulture);
        }

        if (query.Offset.HasValue)
        {
            queryParams["limit_offset"] = query.Offset.Value.ToString(CultureInfo.InvariantCulture);
        }

        return QueryHelpers.AddQueryString($"/transcriptions", queryParams);
    }
}