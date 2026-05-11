using System.Device.Gpio;

namespace LEDPattern
{
    internal class Program
    {
        static GpioController controller = new(PinNumberingScheme.Board);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int red = 16;
            int yellow = 18;
            int green = 22;
            int blue = 36;


            controller.OpenPin(red, PinMode.Output);
            int times = 40;
            while (true)
            {
                Flash(red, times);
                Flash(yellow, times);
                Flash(green, times);
                Flash(blue, times);
            }

            static void Flash(int pin, int time)
            {
                controller.OpenPin(pin, PinMode.Output);
                controller.Write(pin, PinValue.High);
                Thread.Sleep(time);
                controller.Write(pin, PinValue.Low);
                controller.ClosePin(pin);
            }

        }
    }
}


