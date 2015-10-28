using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace InvokeSagaExceptionInNoSagaEndpoint
{
    public class CommandXHandler : IHandleMessages<CommandX>
    {
        public void Handle(CommandX message)
        {
            throw new NotImplementedException();
        }
    }
}
