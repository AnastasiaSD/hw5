using System;

namespace hw5
{
    public class ChatDecoratorAddSignature : ChatDecoratorBase
    {
        public ChatDecoratorAddSignature(IChat chat) : base(chat)
        { }

        public override void SendMessage(IMessage message)
        {
            message.Text = $"{message.Text}\nYours faithfully {message.Author}";
            Decoratee.SendMessage(message);
        }

        public override IMessage ReceiveMessage()
        {
            var message = base.ReceiveMessage();
            message.Text = $"{message.Text}\nYours faithfully {message.Author}";
            return message;
        }
    }
}