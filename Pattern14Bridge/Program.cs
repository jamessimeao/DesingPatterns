namespace Pattern14Bridge
{
    internal class Program()
    {
        public static void Main()
        {
            RemoteControl lgRemoteControl = new RemoteControl(new LGRadio());
            lgRemoteControl.TurnOn();
            lgRemoteControl.TurnOff();

            AdvancedRemoteControl advancedSonyRemoteControl = new AdvancedRemoteControl(new SonyRadio());
            advancedSonyRemoteControl.TurnOn();
            advancedSonyRemoteControl.TurnOff();
            advancedSonyRemoteControl.SetChannel(2);
        }
    }
}