
namespace InfinityBot.Modules;

public struct InfinityConfig {
    public String Token { get; set; }
    public IEnumerable<UInt32>? GuildsIds { get; set; }

    public InfinityConfig(string token, IEnumerable<uint>? guildsIds) {
        Token=token;
        GuildsIds=guildsIds;
    }
}

public struct GuildInfo {

}