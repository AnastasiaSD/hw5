using System;

namespace hw5
{
    public class ChatDecoratorHidingUsers : ChatDecoratorBase
    {
        public ChatDecoratorHidingUsers(IChat chat) : base(chat)
        { }

        public override void SendMessage(IMessage message)
        {
            message.Author = new String('*', message.Author.Length);
            message.Recipient = new String('-', message.Recipient.Length);
            Decoratee.SendMessage(message);
        }
        
        public override IMessage ReceiveMessage()
        {
            var message = base.ReceiveMessage();
            message.Author = new String('#', message.Author.Length);
            message.Recipient = new String('^', message.Recipient.Length);
            return message;
        }
    }
}