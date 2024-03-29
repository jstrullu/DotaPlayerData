﻿using DotaPlayerData.Core;

namespace DotaPlayerData.UI.Data;

public class SearchController
{
    private readonly IHeroService _heroService;
    private readonly IPlayerService _playerService;
    public SearchController(IHeroService heroService, IPlayerService playerService)
    {
        _heroService = heroService;
        _playerService = playerService;
    }

    public async Task<IQueryable<PlayerHero>> SearchTopPlayerHeroes(long steamId)
    {
        return await _heroService.GetTopHeroesForPlayer(steamId);
    }

    public async Task<List<SearchPlayerResult>> SearchPlayer(string name)
    {
        return await _playerService.SearchPlayer(name);
    }
}