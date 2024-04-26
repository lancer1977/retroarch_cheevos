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