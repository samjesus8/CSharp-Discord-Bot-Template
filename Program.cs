namespace DiscordBotTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Bot = new Bot();
            Bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
