﻿namespace DotaPlayerData.Core.Services;

public interface IHeroService
{
    Task<List<Hero>> GetAllDotaHeroes();
    Task<IQueryable<PlayerHero>> GetTopHeroesForPlayer(long steamId);
    Task<List<Match>> GetPlayerMatches(long steamId);
}