using PolyhydraGames.RACheevos.Games.Responses;
using PolyhydraGames.RACheevos.Users.Models;
using System;
using PolyhydraGames.Core.Interfaces;

namespace PolyhydraGames.RACheevos.Users;

public class RetroArchUserApi : RestServiceBase, IRetroArchUserApi
{
    private readonly ICacheService? _redis;

    public RetroArchUserApi(ICheevoAuth authConfig, HttpClient client, ICacheService? redis) : base(authConfig, client)
    {
        _redis = redis;
    }

    public Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(string gameID, string userName)
    {
        var url = GetBaseUrl().User(userName).GameID(gameID);
        return Get<GameInfoAndUserProgressResponse>(url);
    }

    public async Task<IEnumerable<RecentGame>> GetUserRecentlyPlayedGames(string userName, int count = 50)
    {
        var key = nameof(GetUserRecentlyPlayedGames) + userName;
        return await (_redis?.Get(key, async () => await GetUserRecentlyPlayedGamesFunc(userName, count)) ??
                      GetUserRecentlyPlayedGamesFunc(userName, count));

    }

    public async Task<List<RecentGame>> GetUserRecentlyPlayedGamesFunc(string userName, int count = 50)
    {
        var items = new List<RecentGame>();
        if (count > 50)
        {
            var offset = 0;
            while (items.Count < count)
            {
                var result = await GetUserRecentlyPlayedGames(userName, 50, offset);
                items.AddRange(result);
                offset += 50;
            }

            return items;
        }
        var smallresult = await GetUserRecentlyPlayedGames(userName, count, 0);
        return smallresult.ToList();

    }

    private Task<IEnumerable<RecentGame>> GetUserRecentlyPlayedGames(string userName, int count, int offset)
    {
        var url = GetBaseUrl().User(userName).Count(count).Offset(offset);
        return Get<IEnumerable<RecentGame>>(url);
    }

    public Task<GetUserSummaryResponse> GetUserSummary(string userName, int gameCount = 0,
        int achievementCount = 10)
    {
        var url = GetBaseUrl().User(userName) + $"&g={gameCount}&a={achievementCount}";
        return Get<GetUserSummaryResponse>(url);
    }

    public Task<IEnumerable<GameCompletion>> GetUserCompletedGames(string userName)
    {
        var url = GetBaseUrl().User(userName);
        return Get<IEnumerable<GameCompletion>>(url);
    }

    public async Task<UserProfile> GetUserProfile(string userName)
    {
        var url = GetBaseUrl().User(userName);
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
        var url = GetBaseUrl().User(userName) + $"&m={minutes}";
        return Get<IEnumerable<Achievement>>(url);
    }

    public Task<IEnumerable<Achievement>> GetAchievementsEarnedBetween(string userName, DateTime start, DateTime end)
    {
        var url = GetBaseUrl().User(userName) + $"&f={start.ToEpoch()}&t={end.ToEpoch()}";
        return Get<IEnumerable<Achievement>>(url);
    }

    public Task<IEnumerable<Achievement>> GetAchievementsEarnedOnDay(string userName, DateTime day)
    {
        var url = GetBaseUrl() + $"&u={userName}&d={day:yyyy-MM-dd}";
        return Get<IEnumerable<Achievement>>(url);
    }

    public Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(string authUser, string userName, int gameId)
    {
        var url = GetBaseUrl().User(userName).GameID(gameId).AuthUser(authUser).ParamString("a", "1");
        return Get<GameInfoAndUserProgressResponse>(url);
    }



    public Task<UserCompletionProgressResponse> GetUserCompletionProgress(string userName, int count, int offset)
    {
        var url = GetBaseUrl().User(userName).Count(count).Offset(offset);// + $"&u={userName}&c={count}&o={offset}";
        return Get<UserCompletionProgressResponse>(url);
    }

    public Task<UserAwardsResponse> GetUserAwards(string userName)
    {
        var url = GetBaseUrl().User(userName);
        return Get<UserAwardsResponse>(url);
    }

    public Task<IEnumerable<UserClaim>> GetUserClaims(string userName)
    {
        var url = GetBaseUrl().User(userName);
        return Get<IEnumerable<UserClaim>>(url);
    }

    public Task<IEnumerable<UserDetails>> GetUserGameRankAndScore(string userName, int gameId)
    {
        var url = GetBaseUrl().User(userName).GameID(gameId);
        return Get<IEnumerable<UserDetails>>(url);
    }

    public Task<UserPoints> GetUserPoints(string userName)
    {
        var url = GetBaseUrl().User(userName);
        return Get<UserPoints>(url);
    }

    public Task<Dictionary<int, GameProgress>> GetUserProgress(string userName, IEnumerable<int> achievementIds)
    {
        var url = GetBaseUrl().User(userName);
        return Get<Dictionary<int, GameProgress>>(url);
    }

}