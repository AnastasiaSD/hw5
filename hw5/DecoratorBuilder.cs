namespace hw5
{
    public class DecoratorBuilder
    {
        private IChat _chat;

        public DecoratorBuilder(IChat chat)
        {
            _chat = chat;
        }

        public DecoratorBuilder WithHidden()
        {
            _chat = new ChatDecoratorHidingUsers(_chat);
            return this;
        }

        public DecoratorBuilder WithSignature()
        {
            _chat = new ChatDecoratorAddSignature(_chat);
            return this;
        }

        public IChat Build()
        {
            return _chat;
        }
    }
}