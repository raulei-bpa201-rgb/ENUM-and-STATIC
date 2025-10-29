namespace SendMessage
{
    internal class Program
    {
        public enum Menu
        {
            None = 0,
            SendMessageByEmail = 1,
            SendMessageBySms = 2,
        }
        static void Main(string[] args)
        {
            MessageSender.Quit((int)Menu.None);
        }
    }
}
