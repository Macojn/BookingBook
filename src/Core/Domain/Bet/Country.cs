namespace BettingBook.Domain.Bet;

public class Country : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
}
