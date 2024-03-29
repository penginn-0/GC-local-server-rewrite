using Domain.Enums;

namespace Domain.Entities;

public class Unlock
{
    public long       CardId       { get; set; }
    public int        UnlockItemId { get; set; }
    public UnlockType UnlockType   { get; set; }
    public bool       IsNew        { get; set; }
    public DateTime          CreateTime            { get; set; }
    public DateTime          UpdateTime            { get; set; }
}