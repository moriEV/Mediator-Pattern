using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    internal class User
    {
        private string name;
        private IChatMediator chatMediator;
        private List<string> messageHistory;
        public User(string name)
        {
            this.name = name;
            this.messageHistory = new List<string>();
        }
        public void SetMediator(IChatMediator chatMediator)
        {
            this.chatMediator = chatMediator;
        }
        public string GetUserName()
        {
            return name;
        }
        public void ShowMessageHistory()
        {
            foreach (var item in messageHistory) 
            {
                Console.WriteLine(item);
            }
        }
        public void SendMessage(string message,string receiverName)
        {
            chatMediator.SendMessage(message, this, receiverName);
        }
        public void ReceiveMessage(string message, string senderName)
        {
            messageHistory.Add(message);
        }
    }
}
