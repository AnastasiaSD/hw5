namespace hw5
{
    public interface IChat
    {
        void SendMessage(IMessage message);
        IMessage ReceiveMessage();
    }
}