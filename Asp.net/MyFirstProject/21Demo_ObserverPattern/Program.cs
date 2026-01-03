namespace _21Demo_ObserverPattern
{
    public delegate void NotifyEventHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber();
                Publisher publisher = new Publisher();

            publisher.Notify += subscriber.MethodA;
            publisher.Notify += subscriber.MethodB;
            publisher.NotifySubscribers("The Grand Sale is UP! Upto 70% off on selected products!");

            publisher.Notify -= subscriber.MethodB;

            publisher.NotifySubscribers("Flash Sale! Extra 10% off on Electronics!");

        }
    }

    public class Publisher
    {
       
        public event NotifyEventHandler Notify;
        //public void TriggerEvents()
        //{
        //    Notify.Invoke("Event triggered!");
        //}
        public void NotifySubscribers(string message)
        {
            Notify?.Invoke(message); // Null-conditional operator to avoid null reference exception
        }

    }

    public class Subscriber
    {
        public void MethodA(string message)
        {
            Console.WriteLine($"MethodA received: {message} via SMS");
        }
        public void MethodB(string message)
        {
            Console.WriteLine($"MethodB received: {message} via EMail");
        }
    }
}
