using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class NextTrack
{
    [JsonProperty("artist")]
    public string Artist { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("album")]
    public string Album { get; set; }

    [JsonProperty("albumArtUri")]
    public string AlbumArtUri { get; set; }

    [JsonProperty("duration")]
    public long Duration { get; set; }

    [JsonProperty("uri")]
    public string Uri { get; set; }
}