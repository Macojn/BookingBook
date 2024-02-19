namespace BettingBook.Domain.Bet;

public class Strategy : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
    public uint Number { get; set; }
}
