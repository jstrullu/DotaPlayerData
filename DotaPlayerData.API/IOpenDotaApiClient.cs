namespace DotaPlayerData.API;

public interface IOpenDotaApiClient
{
    Task<string> GetAllDotaHeroes();
    Task<string> GetPlayerMatches(long steamId);
    Task<string> GetPlayerInfos(long steamId);
    Task<string> SearchPlayer(string name);
<<<<<<< HEAD
    Task<string> GetHeroesConstants();
=======
    Task<string> GetPlayerPeers(long steamId);
>>>>>>> integrating-stratz
}