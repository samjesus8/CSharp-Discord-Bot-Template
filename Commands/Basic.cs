using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace DiscordBotTemplate.Commands
{
    public class Basic : BaseCommandModule
    {
        [Command("test")]
        public async Task TestCommand(CommandContext ctx) 
        {
            await ctx.Channel.SendMessageAsync("Test Message");
        }
    }
}
