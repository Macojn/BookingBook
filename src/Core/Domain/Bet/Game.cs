namespace BettingBook.Domain.Bet;

public class Game : AuditableEntity, IAggregateRoot
{
    public Player PlayerOne { get; set; } = new();
    public Player PlayerTwo { get; set; } = new();
    public DateTime PlayDate { get; set; } = new();
    public Competition Competition { get; set; } = new();
}
