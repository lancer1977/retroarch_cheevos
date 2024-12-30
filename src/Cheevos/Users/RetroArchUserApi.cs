using PolyhydraGames.RACheevos.Games.Responses;
using PolyhydraGames.RACheevos.Users.Models;
using System;

namespace PolyhydraGames.RACheevos.Users;

public class RetroArchUserApi : RestServiceBase, IRetroArchUserApi
{

    public RetroArchUserApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }

    public async Task<IEnumerable<UserRecentlyPlayedGame>> GetUserRecentlyPlayedGames(string userName)
    {
        var url = GetBaseUrl() + $"&u={userName}&c=50";
        return await Get<List<UserRecentlyPlayedGame>>(url);
    }

    public Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(string gameID, string userName)
    {
        var url = GetBaseUrl() + $"&u={userName}";
        return Get<GameInfoAndUserProgressResponse>(url);
    }
    public async Task<IEnumerable<RecentGame>> GetUserRecentlyPlayedGames(string userName, int count = 50)
    {
        if (count > 50)
        {
            var items = new List<RecentGame>();
            var offset = 0;
            while (items.Count < count)
            {
                var result = await GetUserRecentlyPlayedGames(userName, 50, offset);
                items.AddRange(result);
                offset += 50;
            }

            return items;
        }

        return await GetUserRecentlyPlayedGames(userName, count, 0);
    }

    private Task<IEnumerable<RecentGame>> GetUserRecentlyPlayedGames(string userName, int count, int offset)
    {
        var url = GetBaseUrl() + $"&u={userName}&c={count}&o={offset}";
        return Get<IEnumerable<RecentGame>>(url);
    }

    public Task<GetUserSummaryResponse> GetUserSummary(string userName, int gameCount = 0,
        int achievementCount = 10)
    {
        var url = GetBaseUrl() + $"&u={userName}&g={gameCount}&a={achievementCount}";
        return Get<GetUserSummaryResponse>(url);
    }

    public Task<IEnumerable<GameCompletion>> GetUserCompletedGames(string userName)
    {
        var url = GetBaseUrl() + $"&u={userName}";
        return Get<IEnumerable<GameCompletion>>(url);
    }

    public async Task<UserProfile> GetUserProfile(string userName)
    {
        var url = GetBaseUrl(false).ParamString("u", userName);
        try
        {
            var result = await Get<UserProfile>(url);
            return result;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            throw;
        }
    }


    public Task<IEnumerable<Achievement>> GetUserRecentAchievements(string userName, int minutes = 60)
    {
        var url = GetBaseUrl() + $"&u={userName}&m={minutes}";
        return Get<IEnumerable<Achievement>>(url);
    }

    public Task<IEnumerable<Achievement>> GetAchievementsEarnedBetween(string userName, DateTime start, DateTime end)
    {
        var url = GetBaseUrl() + $"&u={userName}&f={start.ToEpoch()}&t={end.ToEpoch()}";
        return Get<IEnumerable<Achievement>>(url);
    }

    public Task<IEnumerable<Achievement>> GetAchievementsEarnedOnDay(string userName, DateTime day)
    {
        var url = GetBaseUrl() + $"&u={userName}&d={day:yyyy-MM-dd}";
        return Get<IEnumerable<Achievement>>(url);
    }

    public Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(string userName, int gameId)
    {
        var url = GetBaseUrl() + $"&u={userName}&g={gameId}";
        return Get<GameInfoAndUserProgressResponse>(url);
    }



    public Task<UserCompletionProgressResponse> GetUserCompletionProgress(string userName, int count, int offset)
    {
        var url = GetBaseUrl() + $"&u={userName}&c={count}&o={offset}";
        return Get<UserCompletionProgressResponse>(url);
    }

    public Task<UserAwardsResponse> GetUserAwards(string userName)
    {
        var url = GetBaseUrl() + $"&u={userName}";
        return Get<UserAwardsResponse>(url);
    }

    public Task<IEnumerable<UserClaim>> GetUserClaims(string userName)
    {
        var url = GetBaseUrl() + $"&u={userName}";
        return Get<IEnumerable<UserClaim>>(url);
    }

    public Task<IEnumerable<UserDetails>> GetUserGameRankAndScore(string userName, int gameId)
    {
        var url = GetBaseUrl() + $"&u={userName}&g={gameId}";
        return Get<IEnumerable<UserDetails>>(url);
    }

    public Task<UserPoints> GetUserPoints(string userName)
    {
        var url = GetBaseUrl() + $"&u={userName}";
        return Get<UserPoints>(url);
    }

    public Task<Dictionary<int, GameProgress>> GetUserProgress(string userName, IEnumerable<int> achievementIds)
    {
        var url = GetBaseUrl() + $"&u={userName}";
        return Get<Dictionary<int, GameProgress>>(url);
    }

}