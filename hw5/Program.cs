using System;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message()
            {
                Author = "Mario",
                Recipient = "Luigi",
                Text = "Oh no, she's not here :("
            };
            
            var chat = new Chat();
            var builder = new DecoratorBuilder(chat);
            builder.WithHidden();
            var onlyHidden = builder.Build();
            builder.WithSignature();
            var imHiddenButHaveSign = builder.Build();
            builder.WithSignature();
            builder.WithSignature();
            builder.WithSignature();
            var iVeryLoveSign = builder.Build();
            
            onlyHidden.SendMessage(message);
            Console.WriteLine("Message received:\n" + onlyHidden.ReceiveMessage());

            Console.WriteLine("========================================================");
            
            imHiddenButHaveSign.SendMessage(message);
            Console.WriteLine("Message received:\n" + imHiddenButHaveSign.ReceiveMessage());
            
            Console.WriteLine("========================================================");
            
            iVeryLoveSign.SendMessage(message);
            Console.WriteLine("Message received:\n" + iVeryLoveSign.ReceiveMessage());
        }
    }
}