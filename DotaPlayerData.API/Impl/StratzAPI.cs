using DotaPlayerData.API.Configuration;
using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

public class StratzApi(StratzConfiguration stratzConfiguration) : IStratzApi
{
    public async Task<string> GetPlayerInfos(long steamId)
    {
        try
        {
            string playerEndpoint = stratzConfiguration.BaseUrl.AppendPathSegment($"player/{steamId}");
            return await playerEndpoint
                .WithOAuthBearerToken(stratzConfiguration.ApiKey)
                .GetStringAsync()
                .ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}
