using Pattern8Mediator.MediatorWithObserver;

namespace Pattern8Mediator
{
    internal class Program
    {
        public static void Main()
        {
            //MediatorPattern();
            MediatorWithObserverPattern();
        }

        public static void MediatorPattern()
        {
            PostDialogBox postDialogBox = new PostDialogBox();
            postDialogBox.SimulateUserInteraction();
        }

        public static void MediatorWithObserverPattern()
        {
            PostDialogBox2 postDialogBox = new PostDialogBox2();
            postDialogBox.SimulateUserInteraction();
        }
    }
}