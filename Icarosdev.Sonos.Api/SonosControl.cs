using Icarosdev.Sonos.Api.Model;
using Newtonsoft.Json;

namespace Icarosdev.Sonos.Api;

public class SonosControl
{
    private readonly HttpClient _client = new() { Timeout = TimeSpan.FromSeconds(Constants.HttpTimeout) };
    private readonly int _port;

    private readonly string _serverAddress;

    public SonosControl(string serverAddress, int port = 5005)
    {
        _serverAddress = serverAddress ?? throw new ArgumentNullException(nameof(serverAddress));
        _port = port;
    }

    public string SonosSererUrlBase => $"http://{_serverAddress}:{_port}/";

    public async Task<Zone[]?> GetAllZones()
    {
        var uri = new Uri($"{SonosSererUrlBase}zones");
        var result = await CallSonos<Zone[]?>(uri);
        return result;
    }

    public async Task<OperationStatus?> PauseAll()
    {
        var uri = new Uri($"{SonosSererUrlBase}pauseall");
        var result = await CallSonos<OperationStatus?>(uri);
        return result;
    }

    public async Task<OperationStatus?> ResumeAll()
    {
        var uri = new Uri($"{SonosSererUrlBase}resumeall");
        var result = await CallSonos<OperationStatus?>(uri);
        return result;
    }

    public async Task<OperationStatus?> PlayPause(string zoneName)
    {
        var uri = new Uri($"{SonosSererUrlBase}{zoneName}/playpause");
        var result = await CallSonos<OperationStatus?>(uri);
        return result;
    }

    public async Task<OperationStatus?> Play(string zoneName)
    {
        var uri = new Uri($"{SonosSererUrlBase}{zoneName}/play");
        var result = await CallSonos<OperationStatus?>(uri);
        return result;
    }
    public async Task<OperationStatus?> Pause(string zoneName)
    {
        var uri = new Uri($"{SonosSererUrlBase}{zoneName}/pause");
        var result = await CallSonos<OperationStatus?>(uri);
        return result;
    }

    public async Task<OperationStatus?> Mute(string zoneName)
    {
        var uri = new Uri($"{SonosSererUrlBase}{zoneName}/mute");
        var result = await CallSonos<OperationStatus?>(uri);
        return result;
    }

    public async Task<OperationStatus?> Unmute(string zoneName)
    {
        var uri = new Uri($"{SonosSererUrlBase}{zoneName}/unmute");
        var result = await CallSonos<OperationStatus?>(uri);
        return result;
    }

    private async Task<T?> CallSonos<T>(Uri uri)
    {
        try
        {
            Console.WriteLine($"Calling: {uri.AbsoluteUri}");
            var jsonResult = await _client.GetStringAsync(uri);
            Console.WriteLine($"Answer: {jsonResult}");
            if (string.IsNullOrWhiteSpace(jsonResult) || jsonResult == "[]") return default;
            var result = JsonConvert.DeserializeObject<T>(jsonResult, Converter.Settings);
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}