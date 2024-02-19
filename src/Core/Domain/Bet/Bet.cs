namespace BettingBook.Domain.Bet;

public class Bet : AuditableEntity, IAggregateRoot
{
    public Game Game { get; set; } = new();
    public Bookmaker Bookmaker { get; set; } = new();
    public DateTime Date { get; set; }
    public Strategy Strategy { get; set; } = new();
    public Type Type { get; set; } = new();
    public decimal? Odds { get; set; }
    public decimal? SuggestedStake { get; set; }
    public decimal? Stake { get; set; }
    public bool? Successfull { get; set; }
    public decimal Winnings { get; set; }
    public string? AdditionalInfo { get; set; }
}
