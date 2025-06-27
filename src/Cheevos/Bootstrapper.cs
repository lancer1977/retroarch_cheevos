using Microsoft.Extensions.DependencyInjection;
using PolyhydraGames.RACheevos.Achievements;
using PolyhydraGames.RACheevos.Events;
using PolyhydraGames.RACheevos.Feeds;
using PolyhydraGames.RACheevos.Games;
using PolyhydraGames.RACheevos.Systems;
using PolyhydraGames.RACheevos.Tickets;
using PolyhydraGames.RACheevos.Users;

namespace PolyhydraGames.RACheevos
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddRA(this IServiceCollection services)
        {
            services.AddScoped<IRetroArchAchievementApi, AchievementApi>();
            services.AddScoped<IRetroArchEventApi, EventApi>();
            services.AddScoped<IRetroArchFeedApi, RetroArchFeedApi>();
            services.AddScoped<IRetroArchGameApi, RetroArchCheevoApi>();
            services.AddScoped<IRetroArchSystemApi, RetroArchSystemApi>();
            services.AddScoped<IRetroArchUserApi, RetroArchUserApi>();
            services.AddScoped<IRetroArchTicketApi, RetroArchTicketApi>();
            return services;
        }
    }
}