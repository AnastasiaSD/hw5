using System;

namespace hw5
{
    public class Chat : IChat
    {
        public void SendMessage(IMessage message)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Message sent: ");
            Console.WriteLine(message);
            Console.WriteLine("----------------------------------------");
        }

        public IMessage ReceiveMessage()
        {
            return new Message()
            {
                Author = "Luigi",
                Recipient = "Mario",
                Text = "It is very sad"
            };
        }
    }
}