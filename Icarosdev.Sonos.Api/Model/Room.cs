using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model;

public class Room
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("state")]
    public State State { get; set; }

    [JsonProperty("roomName")]
    public string RoomName { get; set; }

    [JsonProperty("coordinator")]
    public string CoordinatorCoordinator { get; set; }

    [JsonProperty("groupState")]
    public GroupState GroupState { get; set; }
}