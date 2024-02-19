namespace BettingBook.Domain.Bet;

public class Player : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
}
