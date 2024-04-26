public static class ApiUrls
{
    public static int ToEpoch(this DateTime time)
    {
        var t = time.ToUniversalTime() - new DateTime(1970, 1, 1);
        int secondsSinceEpoch = (int)t.TotalSeconds;
        return secondsSinceEpoch;
    }
}