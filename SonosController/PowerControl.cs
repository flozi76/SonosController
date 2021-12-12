using InnerCore.Api.SonosHttp;

namespace SonosController;

internal class PowerControl
{
    private readonly SonosClient _sonosClient;

    public PowerControl(SonosClient sonosClient)
    {
        _sonosClient = sonosClient;
    }

    public void TogglePause()
    {
    
    }
}