using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class PlayMode
{
    [JsonProperty("repeat")]
    public string Repeat { get; set; }

    [JsonProperty("shuffle")]
    public bool Shuffle { get; set; }

    [JsonProperty("crossfade")]
    public bool Crossfade { get; set; }
}