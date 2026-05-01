using System.Device.Gpio;
namespace RaspberryPiCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GpioController controller = new GpioController(PinNumberingScheme.Board);
            int[] pins = { };
            controller.OpenPin(40, PinMode.Output);
            controller.Write(40, PinValue.High);
            controller.ClosePin(40);
        }
    }
}
