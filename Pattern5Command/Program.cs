using Pattern5Command.Bad;
using Pattern5Command.Good;

namespace Pattern5Command
{
    internal class Program
    {
        public static void Main()
        {
            //Bad();
            Good();
        }

        public static void Bad()
        {
            Light light = new Light();
            BadRemoteControl controller = new BadRemoteControl(light);
            controller.PressButton(true);
            controller.PressButton(false);
        }

        public static void Good()
        {
            Light light = new Light();
            TurnOnCommand turnOn = new TurnOnCommand(light);
            TurnOffCommand turnOff = new TurnOffCommand(light);
            RemoteController controller = new RemoteController(turnOn);
            controller.PressButton();
            controller.SetCommand(turnOff);
            controller.PressButton();
        }
    }
}