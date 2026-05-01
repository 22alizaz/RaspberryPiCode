using System.Device.Gpio;
using System.Runtime.ExceptionServices;
namespace RaspberryPiCode
{
    internal class Program
    {
    static void wipe(GpioController controller, int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                controller.OpenPin(pins[i], PinMode.Output);
                controller.Write(pins[i], PinValue.High);
                controller.ClosePin(pins[i]);
            }
        }
         
        static void Main(string[] args)
        {
            GpioController controller = new GpioController(PinNumberingScheme.Board);
            int[] pins = { 11, 13, 15, 29 };
            wipe (controller, pins);

            Thread.Sleep(2000);
        }

    }
}
