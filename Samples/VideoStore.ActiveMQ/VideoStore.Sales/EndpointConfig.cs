namespace VideoStore.Sales
{
    using System;
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, UsingTransport<ActiveMQ>
    {
    }


    public class MyClass:IWantToRunWhenBusStartsAndStops
    {
        public void Start()
        {
            Console.Out.WriteLine("The VideoStore.Sales endpoint is now started and ready to accept messages");
        }

        public void Stop()
        {
            
        }
    }
}
