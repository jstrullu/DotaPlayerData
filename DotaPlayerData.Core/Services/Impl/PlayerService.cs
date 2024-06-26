﻿using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Models;
using DotaPlayerData.Core.Models.OpenDota;
using DotaPlayerData.Core.Models.Stratz;
using Profile = DotaPlayerData.Core.Models.Profile;
using Team = DotaPlayerData.Core.Models.Team;

namespace DotaPlayerData.Core.Services.Impl;

public class PlayerService(IOpenDotaApiClient openDotaApiClient, IStratzApi stratzApi) : IPlayerService
{

    public async Task<List<SearchPlayerResult>> SearchPlayer(string name)
    {
        try
        {
            var result = await openDotaApiClient.SearchPlayer(name);
            return JsonSerializer.Deserialize<List<SearchPlayerResult>>(result);
        }
        catch (JsonException e)
        {
            throw;
        }
    }
    
    public async Task<Player> GetCurrentPlayerInfos(long steamId)
    {
        var result = await openDotaApiClient.GetPlayerInfos(steamId).ConfigureAwait(false);
        
        var openDotaPlayer = JsonSerializer.Deserialize<OpenDotaPlayer>(result) ?? throw new InvalidOperationException();

        result = await stratzApi.GetPlayerInfos(steamId).ConfigureAwait(false);

        var stratzPlayer = JsonSerializer.Deserialize<StratzPlayer>(result);
        
        return GetMergedPlayerInfos(stratzPlayer, openDotaPlayer);
    }

    private Player GetMergedPlayerInfos(StratzPlayer stratzPlayer, OpenDotaPlayer openDotaPlayer)
    {
        return new Player
        {
            Profile = new Profile
            {
                Avatar = openDotaPlayer.Profile.Avatar,
                Name = openDotaPlayer.Profile.Name,
                AllNames = stratzPlayer.Names.Select(n => n.Naming).ToList()
            },
            CountryCode = openDotaPlayer.Profile.CountryCode,
            MainRank = openDotaPlayer.MainRank,
            RankStars = openDotaPlayer.RankStars,
            WinCount = stratzPlayer.WinCount,
            MatchCount = stratzPlayer.MatchCount,
            Team = new Team
            {
                Name = stratzPlayer.Team.Name,
                Logo = stratzPlayer.Team.Logo
            }
        };
    }
}