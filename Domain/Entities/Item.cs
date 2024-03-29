namespace Domain.Entities;

public class Item
{
    public long CardId { get; set; }

    public int ItemId { get; set; }

    public int Count { get; set; }
    
    public DateTime CreateTime { get; set; }
    public DateTime        UpdateTime          { get; set; }
}