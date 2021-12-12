using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class CurrentTrack
{
    [JsonProperty("artist")]
    public string Artist { get; set; }

    [JsonProperty("albumArtUri")]
    public string AlbumArtUri { get; set; }

    [JsonProperty("duration")]
    public long Duration { get; set; }

    [JsonProperty("uri")]
    public string Uri { get; set; }

    [JsonProperty("trackUri")]
    public string TrackUri { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("stationName")]
    public string StationName { get; set; }

    [JsonProperty("absoluteAlbumArtUri")]
    public Uri AbsoluteAlbumArtUri { get; set; }
}