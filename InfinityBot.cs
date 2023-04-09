namespace InfinityBot;

public class InfinityBot {
    public static async Task Main() {
        Visual.WriteHeader();
        await new InfinityBot().StartBotAsync();
    }

    private async Task StartBotAsync() {
        await Task.Delay(-1);
    }
}