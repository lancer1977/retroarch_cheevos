using System;

namespace PolyhydraGames.RACheevos.Feeds;

public interface IRetroArchFeedApi
{
    //GetRecentGameAwards
    //d date default now
    //o offset 0 default
    //c count 25
    //k kinds default all

    Task<RecentGameAwardResponse> GetRecentGameAwards(DateTime? date = null, int offset = 0, int count = 25, string kinds = null);
    Task<IEnumerable<ActiveClaim>> GetActiveClaims();
    Task<IEnumerable<ActiveClaim>> GetClaims();
    Task<IEnumerable<RankedUser>> GetTopTenUsers();
}

