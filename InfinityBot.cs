using InfinityBot.Properties;
using Microsoft.Extensions.Configuration;

namespace InfinityBot;

public class InfinityBot {
    private String? Token { get; init; }

    public InfinityBot(String? token = null) {
        Token = token is not null ? token :
            AppSettings.Default.Token ?? throw new NullReferenceException("Token is null");
    }

    public static async Task Main() {
        Visual.WriteHeader();
        await new InfinityBot().StartBotAsync();
    }

    private async Task StartBotAsync() {
        await Task.Delay(-1);
    }
}