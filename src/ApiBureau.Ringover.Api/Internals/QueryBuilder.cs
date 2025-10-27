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
            queryParams["sart_date"] = query.StartDate.Value.ToString("o", CultureInfo.InvariantCulture);
        }

        if (query.EndDate.HasValue)
        {
            queryParams["end_date"] = query.EndDate.Value.ToString("o", CultureInfo.InvariantCulture);
        }

        if (query.Limit.HasValue)
        {
            queryParams["limit"] = query.Limit.Value.ToString(CultureInfo.InvariantCulture);
        }

        return QueryHelpers.AddQueryString($"/calls", queryParams);
    }
}