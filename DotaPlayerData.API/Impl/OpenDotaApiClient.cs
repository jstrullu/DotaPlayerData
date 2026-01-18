<<<<<<< HEAD
﻿using DotaPlayerData.API.Configuration;
=======
using DotaPlayerData.API.Configuration;
>>>>>>> integrating-stratz
using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

<<<<<<< HEAD
// All the code in this file is included in all platforms.
public class OpenDotaApiClient(OpenDotaConfiguration openDotaConfiguration) : IOpenDotaApiClient
{

=======
public class OpenDotaApiClient(OpenDotaConfiguration openDotaConfiguration) : IOpenDotaApiClient
{
>>>>>>> integrating-stratz
    public async Task<string> GetAllDotaHeroes()
    {
        try
        {
            string heroesEndPoint = openDotaConfiguration.BaseUrl.AppendPathSegment("heroes");
<<<<<<< HEAD

            var response = await heroesEndPoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
=======
            return await heroesEndPoint.GetStringAsync().ConfigureAwait(false);
>>>>>>> integrating-stratz
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
<<<<<<< HEAD

            var response = await matchEndpoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
=======
            return await matchEndpoint.GetStringAsync().ConfigureAwait(false);
>>>>>>> integrating-stratz
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
<<<<<<< HEAD

            var response = await playerEndpoint.GetAsync().ConfigureAwait(false);
        
            return await response.GetStringAsync().ConfigureAwait(false);
=======
            return await playerEndpoint.GetStringAsync().ConfigureAwait(false);
>>>>>>> integrating-stratz
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
<<<<<<< HEAD
            var response = await searchEndpoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
=======
            return await searchEndpoint.GetStringAsync().ConfigureAwait(false);
>>>>>>> integrating-stratz
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

<<<<<<< HEAD
    public async Task<string> GetHeroesConstants()
    {
        string heroesConstantsEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment("constants/heroes");
        var response = await heroesConstantsEndpoint.GetAsync().ConfigureAwait(false);

        return await response.GetStringAsync().ConfigureAwait(false);
    }
}
=======
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
>>>>>>> integrating-stratz
