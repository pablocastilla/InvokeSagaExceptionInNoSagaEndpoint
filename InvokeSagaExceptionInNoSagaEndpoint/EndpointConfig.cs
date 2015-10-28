
namespace InvokeSagaExceptionInNoSagaEndpoint
{
    using NServiceBus;

    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {

            configuration.UsePersistence<InMemoryPersistence>();
            configuration.Pipeline.Register<ConnectionOpenerStep>();
        }
    }

    public class MyClass : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }

        public void Start()
        {          
            RunSamples();

        }

        private void RunSamples()
        {            
            Bus.Send(new CommandX());
                     
        }


        public void Stop()
        {

        }
    }
}
