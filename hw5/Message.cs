namespace hw5
{
    public class Message : IMessage
    {
        public string Author { get; set; }
        public string Recipient { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"Author: {Author}\nRecipient: {Recipient}\nText: {Text}";
        }
    }
}