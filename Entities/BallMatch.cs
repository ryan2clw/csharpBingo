using WebApi.Entities;

public class BallMatch
{
    public int Id { get; set; }
    public int BallId { get; set; }
    public int RowId { get; set; }
    public virtual Ball Ball { get; set; }
    public virtual Row Row { get; set; }
}