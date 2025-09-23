namespace ApiBureau.Ringover.Api.Queries;

public sealed record PayrollQuery(
    string CompanyId,
    DateOnly PayDateStart,
    DateOnly PayDateEnd,
    IReadOnlyCollection<StatusType>? Statuses = null,
    IReadOnlyCollection<PayrollType>? PayrollTypes = null)
{
    public static PayrollQuery CreateDefault(string companyId, DateOnly start, DateOnly end) =>
    new(companyId, start, end,
        Statuses: [StatusType.Approved],
        PayrollTypes: [PayrollType.Regular]);
}