namespace hw5
{
    public class ChatDecoratorBase : IChat
    {
        protected readonly IChat Decoratee;

        protected ChatDecoratorBase(IChat chat)
        {
            Decoratee = chat;
        }

        public virtual void SendMessage(IMessage message)
        {
            Decoratee.SendMessage(message);
        }

        public virtual IMessage ReceiveMessage()
        {
            return Decoratee.ReceiveMessage();
        }
    }
}