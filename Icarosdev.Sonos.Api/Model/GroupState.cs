using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class GroupState
{
    [JsonProperty("volume")]
    public long Volume { get; set; }

    [JsonProperty("mute")]
    public bool Mute { get; set; }
}