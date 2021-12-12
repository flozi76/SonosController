using InnerCore.Api.SonosHttp;
using InnerCore.Api.SonosHttp.Models;

namespace SonosController;

internal class VolumeControl
{
    private readonly SonosClient _sonosClient;

    public VolumeControl(SonosClient sonosClient)
    {
        _sonosClient = sonosClient;
    }

    public async Task PerformAction()
    {
        var zones = await _sonosClient.GetAllZones();
        foreach (Zone zone in zones)
        {
            
        }

        while (true)
        {
            Console.WriteLine("Enter Volume [0-100]");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out var newVolume)) continue;

            foreach (var roomName in zones.SelectMany(z => z.Members.Select(m => m.RoomName)))
            {
                await _sonosClient.SetAbsoluteGroupVolume(roomName, newVolume);
                Console.WriteLine($"updated volume to {newVolume}");
            }

            break;
        }
    }
}