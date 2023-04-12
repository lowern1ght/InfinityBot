using InfinityBot.Properties;
using Microsoft.Extensions.Configuration;

namespace InfinityBot;

public class InfinityBot {
    private String? Token { get; init; }
    private Logger Logger { get; init; } = new Logger();

    public InfinityBot(String? token = null) {
        Token = token is not null ? token :
            AppSettings.Default.Token ?? throw new NullReferenceException("Token is null");
        Logger.Log("Token: {a}{b}", Serilog.Events.LogEventLevel.Debug, Token[0..20], "...");
    }

    public static async Task Main() {
        Visual.WriteHeader();
        await new InfinityBot().StartBotAsync();
    }

    private async Task StartBotAsync() {
        await Logger.Log("Bot started", Serilog.Events.LogEventLevel.Information);
        await Task.Delay(-1);
    }
}