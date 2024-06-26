﻿using DotaPlayerData.API;
using DotaPlayerData.API.Impl;
using DotaPlayerData.Core.Services;
using DotaPlayerData.Core.Services.Impl;
using DotaPlayerData.UI.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MudBlazor.Services;

namespace DotaPlayerData.UI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });
        
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddScoped<IOpenDotaApiClient, OpenDotaApiClient>();
        builder.Services.AddScoped<IHeroService, HeroService>();
        builder.Services.AddScoped<IPlayerService, PlayerService>();
        builder.Services.AddScoped<SearchController>();

        return builder.Build();
    }
}