using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class Equalizer
{
    [JsonProperty("bass")]
    public long Bass { get; set; }

    [JsonProperty("treble")]
    public long Treble { get; set; }

    [JsonProperty("loudness")]
    public bool Loudness { get; set; }
}