namespace BettingBook.Domain.Bet;

public class Bookmaker : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
    public decimal AccountBalance { get; set; }
    public decimal Fee { get; set; }
    public string? AdditionalInfo { get; set; }
}
