using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class Zone
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("coordinator")]
    public Room Room { get; set; }

    [JsonProperty("members")]
    public Room[] Members { get; set; }
}