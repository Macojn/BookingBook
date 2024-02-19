namespace BettingBook.Domain.Bet;

public class Type : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
}
