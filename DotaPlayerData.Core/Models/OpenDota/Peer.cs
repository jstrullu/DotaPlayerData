using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.OpenDota;

public class Peer
{
    [JsonPropertyName("account_id")]
    public long AccountId { get; set; }

    [JsonPropertyName("last_played")]
    public long? LastPlayed { get; set; }

    [JsonPropertyName("win")]
    public int Win { get; set; }

    [JsonPropertyName("games")]
    public int Games { get; set; }

    [JsonPropertyName("with_win")]
    public int WithWin { get; set; }

    [JsonPropertyName("with_games")]
    public int WithGames { get; set; }

    [JsonPropertyName("against_win")]
    public int AgainstWin { get; set; }

    [JsonPropertyName("against_games")]
    public int AgainstGames { get; set; }

    [JsonPropertyName("with_gpm_sum")]
    public long? WithGpmSum { get; set; }

    [JsonPropertyName("with_xpm_sum")]
    public long? WithXpmSum { get; set; }

    [JsonPropertyName("personaname")]
    public string PersonaName { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("is_contributor")]
    public bool IsContributor { get; set; }

    [JsonPropertyName("is_subscriber")]
    public bool IsSubscriber { get; set; }

    [JsonPropertyName("last_login")]
    public string LastLogin { get; set; }

    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    [JsonPropertyName("avatarfull")]
    public string AvatarFull { get; set; }

    public double WinRate => WithGames > 0 ? (double)WithWin / WithGames * 100 : 0;

    public int LossCount => WithGames - WithWin;
}
