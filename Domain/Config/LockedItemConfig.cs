using System.Text.Json.Serialization;
using Domain.Enums;

namespace Domain.Config;

public class LockedItemConfig
{
    public const string LOCKED_SECTION = "Locked";
    
    public int ItemId { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public UnlockType ItemType { get; set; }
}