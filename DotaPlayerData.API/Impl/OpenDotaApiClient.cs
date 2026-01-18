using DotaPlayerData.API.Configuration;
using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

public class OpenDotaApiClient(OpenDotaConfiguration openDotaConfiguration) : IOpenDotaApiClient
{
    public async Task<string> GetAllDotaHeroes()
    {
        try
        {
            string heroesEndPoint = openDotaConfiguration.BaseUrl.AppendPathSegment("heroes");
            return await heroesEndPoint.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException ex)
        {
            throw;
        }
    }

    public async Task<string> GetPlayerMatches(long steamId)
    {
        try
        {
            string matchEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment($"players/{steamId}/matches");
            return await matchEndpoint.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

    public async Task<string> GetPlayerInfos(long steamId)
    {
        try
        {
            string playerEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment($"players/{steamId}");
            return await playerEndpoint.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

    public async Task<string> SearchPlayer(string name)
    {
        try
        {
            string searchEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment("search").SetQueryParam("q", name);
            return await searchEndpoint.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

    public async Task<string> GetPlayerPeers(long steamId)
    {
        try
        {
            string peersEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment($"players/{steamId}/peers");
            return await peersEndpoint.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}
