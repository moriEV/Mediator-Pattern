using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    internal interface IChatMediator
    {
        void SendMessage(string message,User user, string receiverName);
        void AddUser(User user);
    }
}
