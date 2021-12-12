using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class State
{
    [JsonProperty("volume")]
    public long Volume { get; set; }

    [JsonProperty("mute")]
    public bool Mute { get; set; }

    [JsonProperty("equalizer")]
    public Equalizer Equalizer { get; set; }

    [JsonProperty("currentTrack")]
    public CurrentTrack CurrentTrack { get; set; }

    [JsonProperty("nextTrack")]
    public NextTrack NextTrack { get; set; }

    [JsonProperty("trackNo")]
    public long TrackNo { get; set; }

    [JsonProperty("elapsedTime")]
    public long ElapsedTime { get; set; }

    [JsonProperty("elapsedTimeFormatted")]
    public DateTimeOffset ElapsedTimeFormatted { get; set; }

    [JsonProperty("playbackState")]
    public string PlaybackState { get; set; }

    [JsonProperty("playMode")]
    public PlayMode PlayMode { get; set; }
}