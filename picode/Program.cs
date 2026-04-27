using System.Device.Gpio;

namespace picode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GpioController controller = new(PinNumberingScheme.Board);
            controller.OpenPin(40, PinMode.Output);
            controller.Write(40, PinValue.High);
            controller.ClosePin(40);

        }
    }
}
