namespace BettingBook.Domain.Bet;

public class Competition : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
    public Country Country { get; set; } = new();
}
