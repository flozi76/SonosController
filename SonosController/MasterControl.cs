using InnerCore.Api.SonosHttp;

namespace SonosController
{
    internal class MasterControl
    {
        private readonly SonosClient _sonosClient;
        private readonly VolumeControl _volumeControl;
        private readonly PowerControl _powerControl;

        public MasterControl(SonosClient sonosClient)
        {
            _sonosClient = sonosClient;
            _volumeControl = new VolumeControl(sonosClient);
            _powerControl = new PowerControl(sonosClient);
        }

        public async Task StartControl()
        {
            var control = true;
            while (control)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 Volume Control");
                Console.WriteLine("2 Off");
                Console.WriteLine("3 On");
                Console.WriteLine("4 ...");
                Console.WriteLine("5 Exit");

                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    switch (result)
                    {
                        case 1:
                        {
                            await _volumeControl.PerformAction();
                            break;
                        }
                        case 2:
                        {
                            await _sonosClient.PauseAll();
                            break;
                        }
                        case 3:
                        {
                            await _sonosClient.ResumeAll();
                            break;
                        }
                        case 5:
                        {
                            control = false;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Ending Control");
        }
    }
}
