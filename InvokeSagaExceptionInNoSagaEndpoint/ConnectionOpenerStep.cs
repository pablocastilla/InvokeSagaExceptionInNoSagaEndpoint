using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus.Pipeline;
using NServiceBus.Pipeline.Contexts;

namespace InvokeSagaExceptionInNoSagaEndpoint
{
    public class ConnectionOpenerBehavior : IBehavior<IncomingContext>
    {        

        public void Invoke(IncomingContext context, Action next)
        {
        
        }

    }

    class ConnectionOpenerStep : RegisterStep
    {
        public ConnectionOpenerStep()
            : base("ConnectionOpenerStep", typeof(ConnectionOpenerBehavior), "opens the connection to the database before the handler is processed")
        {
            
            InsertBefore(WellKnownStep.InvokeSaga);
            //InsertBefore(WellKnownStep.InvokeHandlers); <-- this and others step works, Saga doesn't
        }
    }
}
