namespace PolyhydraGames.RACheevos;

public static class AppendExtensions
{
    public static int ToEpoch(this DateTime time)
    {
        var t = time.ToUniversalTime() - new DateTime(1970, 1, 1);
        int secondsSinceEpoch = (int)t.TotalSeconds;
        return secondsSinceEpoch;
    }
    public static string Id(this string url, int id)
    {

        return url + $"&i={id}";
    }



    public static string ParamBool(this string url, string param, bool value)
    {
        var result = value ? 1 : 0;
        return url + $"&{param}={result}";
    }
    public static string ParamString(this string url, string param, string value)
    {
        return url + $"&{param}={value}";
    }

    public static string AuthUser(this string url, string? userName)
    {
        if (userName == null)
        {
            return url;
        }
        return url + $"&z={userName}";
    }

    public static string ApiKey(this string url, string? apiKey)
    {
        if (apiKey == null)
        {
            return url;
        }
        return url + $"&y={apiKey}";
    }

    public static string Offset(this string url, int? offset)
    {
        if (offset == null)
        {
            return url;
        }
        return url + $"&o={offset}";
    }

    public static string Count(this string url, int? count)
    {
        if (count == null)
        {
            return url;
        }
        return url + $"&c={count}";
    }

    public static string GameID(this string url, string? gameId)
    {
        if (gameId == null)
        {
            return url;
        }
        return url + $"&g={gameId}";
    }

    public static string GameID(this string url, int? gameId)
    {
        if (gameId == null)
        {
            return url;
        }
        return url + $"&g={gameId}";
    }

    public static string User(this string url, string? user)
    {
        if (user == null)
        {
            return url;
        }
        return url + $"&u={user}";
    }

    public static string Kinds(this string url, string? kinds)
    {
        if (kinds == null)
        {
            return url;
        }
        return url + $"&k={kinds}";
    }

    public static string Date(this string url, DateTime? date)
    {
        if (date == null)
        {
            return url;
        }
        return url + $"&d={date:yyyy-MM-dd}";
    }
}