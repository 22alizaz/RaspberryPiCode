using System.Device.Gpio;
namespace RaspberryPiCode
{
    internal class Program
    {
        static void wipe(GpioController controller, int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                controller.OpenPin(pins[i], PinMode.Output);
                controller.Write(pins[i], PinValue.Low);
                controller.ClosePin(pins[i]);
            }
        }
         
        static void Main(string[] args)
        {
            GpioController controller = new GpioController(PinNumberingScheme.Board); 
            int Greenpin = 11;
            int yellowpin = 13;
            int redpin = 15;
            int bluepin = 29;
            int[] pins = { Greenpin, yellowpin, redpin, bluepin };
            int lightTime = 500;
            wipe(controller, pins);
            controller.OpenPin(pins[1], PinMode.Output);
            controller.Write(pins[1], PinValue.High);
            controller.ClosePin(pins[1]);
        }

    }
}
