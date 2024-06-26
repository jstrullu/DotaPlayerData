﻿using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

// All the code in this file is included in all platforms.
public class OpenDotaApiClient : IOpenDotaApiClient
{
    private readonly string _baseUri;

    public OpenDotaApiClient()
    {
        _baseUri = "https://api.opendota.com/api/";
    }
    
    public async Task<string> GetAllDotaHeroes()
    {
        try
        {
            string heroesEndPoint = _baseUri.AppendPathSegment("heroes");

            var response = await heroesEndPoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
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
            string matchEndpoint = _baseUri.AppendPathSegment($"players/{steamId}/matches");

            var response = await matchEndpoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
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
            string playerEndpoint = _baseUri.AppendPathSegment($"players/{steamId}");

            var response = await playerEndpoint.GetAsync().ConfigureAwait(false);
        
            return await response.GetStringAsync().ConfigureAwait(false);
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
            string searchEndpoint = _baseUri.AppendPathSegment("search").SetQueryParam("q", name);
            var response = await searchEndpoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}