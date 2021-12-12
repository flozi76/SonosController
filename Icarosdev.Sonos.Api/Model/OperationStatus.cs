using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api.Model
{
    public class OperationStatus
    {
        [JsonProperty("status")]
        public string? Status { get; set; }
    }
}
