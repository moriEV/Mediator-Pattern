using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    internal class ChatMediator : IChatMediator
    {
        private List<User> users;
        public ChatMediator()
        {
            this.users = new List<User>();
        }
        public void AddUser(User user) 
        {
            users.Add(user);
            user.SetMediator(this);
        }
        public void SendMessage(string message, User sender, string receiverName)
        {
            var receiver = users.FirstOrDefault(user => user.GetUserName() == receiverName);

            if (receiver != null)
            {
                receiver.ReceiveMessage(message, sender.GetUserName());
            }
            else
            {
                Console.WriteLine($"Пользователь с именем {receiverName} не найден.");
            }
        }

    }
}
