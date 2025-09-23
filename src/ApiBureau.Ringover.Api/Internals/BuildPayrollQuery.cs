using ApiBureau.Ringover.Api.Queries;
using Microsoft.AspNetCore.WebUtilities;
using System.Globalization;
using System.Text;

namespace ApiBureau.Ringover.Api.Internals;

internal static class QueryBuilder
{
    private static readonly List<string> _includes = ["Earnings", "Employee Taxes", "Employer Taxes", "Deductions/Contributions"];

    public static string BuildPayrollQuery(PayrollQuery query)
    {
        var queryParams = new Dictionary<string, string?>
        {
            ["Pay Date Start"] = query.PayDateStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
            ["Pay Date End"] = query.PayDateEnd.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
        };

        var url = QueryHelpers.AddQueryString("/payroll/payrollEarnings/getAllPayrollInformation", queryParams);

        var sb = new StringBuilder(url);

        if (query.Statuses is { Count: > 0 })
        {
            foreach (var status in query.Statuses)
                sb.Append("&Status=").Append(Uri.EscapeDataString(status.ToString()));
        }

        if (query.PayrollTypes is { Count: > 0 })
        {
            foreach (var type in query.PayrollTypes)
                sb.Append("&Payroll Type=").Append(Uri.EscapeDataString(type.ToString()));
        }

        foreach (var include in _includes)
            sb.Append("&Include=").Append(Uri.EscapeDataString(include));

        return sb.ToString();
    }
}