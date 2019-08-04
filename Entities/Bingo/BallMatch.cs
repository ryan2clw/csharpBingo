using SpaBingo.Entities.Bingo;

public class BallMatch
{
    public int Id { get; set; }
    public int BallId { get; set; }
    public int MatchId { get; set; }
    public virtual Ball Ball { get; set; }
    public virtual Match Match { get; set; }
}