using Microsoft.Extensions.Configuration;

namespace InfinityBot;

public class InfinityBot {
    private IConfiguration? Configuration { get; init; }

    public InfinityBot() { }
    public InfinityBot(IConfiguration configuration) {
        Configuration = configuration;
    }

    public static async Task Main() {
        Visual.WriteHeader();
        await new InfinityBot().StartBotAsync();
    }

    private async Task StartBotAsync() {
        await Task.Delay(-1);
    }
}