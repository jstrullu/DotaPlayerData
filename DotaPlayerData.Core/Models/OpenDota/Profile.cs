﻿using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.OpenDota;

public class Profile
{
    [JsonPropertyName("personaname")]
    public string Name { get; set; }

    [JsonPropertyName("avatarfull")]
    public string Avatar { get; set; }
    
    [JsonPropertyName("loccountrycode")]
    public string CountryCode { get; set; }
    
    public List<PlayerHero> Heroes { get; set; }
    public List<Match> Matches { get; set; }
}