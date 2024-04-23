using CommunityToolkit.Maui;
using MemoryToolkit.Maui;
using Microsoft.Extensions.Logging;
using SadMemory.Pages;
using SadMemory.ViewModels;

namespace SadMemory;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<DashboardPageViewModel>();
        builder.Services.AddTransient<LocationPage>();
        builder.Services.AddTransient<LocationPageViewModel>();
        builder.Services.AddTransient<EquipmentListPage>();
        builder.Services.AddTransient<EquipmentListPageViewModel>();
        builder.Services.AddTransient<EquipmentDetailPage>();
        builder.Services.AddTransient<EquipmentDetailPageViewModel>();
        
        Routing.RegisterRoute(nameof(EquipmentListPage), typeof(EquipmentListPage));
        Routing.RegisterRoute(nameof(EquipmentDetailPage), typeof(EquipmentDetailPage));
        
#if DEBUG
        // Configure logging
        builder.Logging.AddDebug();
    
        // Ensure UseLeakDetection is called after logging has been configured!
        builder.UseLeakDetection(collectionTarget =>
        {
            // This callback will run any time a leak is detected.
            Application.Current?.MainPage?.DisplayAlert("💦Leak Detected💦",
                $"❗🧟❗{collectionTarget.Name} is a zombie!", "OK");
        });
#endif

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}