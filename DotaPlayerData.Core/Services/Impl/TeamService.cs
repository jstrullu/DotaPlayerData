using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Models.Stratz;
using Flurl.Http;

namespace DotaPlayerData.Core.Services.Impl;

public class TeamService(IStratzApi stratzApi) : ITeamService
{
    public async Task<Team> GetTeam(long teamId)
    {
        try
        {
            var result = await stratzApi.GetTeamInfos(teamId);
            return JsonSerializer.Deserialize<Team>(result);

        }
        catch (JsonException)
        {
            throw;
        }
        catch (FlurlHttpException)
        {
            throw;
        }
        
        
    }
}