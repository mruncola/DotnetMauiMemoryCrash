using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

public partial class DashboardPageViewModel(IServiceProvider serviceProvider): ObservableObject
{
    [ObservableProperty] private string _pageTitle = "Dashboard Page";

    [RelayCommand]
    private async Task GoListPage()
    {
        
        var app = (App)Application.Current;
        if (app.UseGoto)
        {
            await Shell.Current.GoToAsync($"///{nameof(LocationPage)}", true);
        }
        else
        {
            Console.WriteLine("Use PushPop");
            var page = serviceProvider.GetService<LocationPage>();
            Shell.Current.Navigation.PushAsync(page);
        }
    }
    
    [RelayCommand]
    private async Task GoDashPage()
    {
        var app = (App)Application.Current;
        if (app.UseGoto)
        {
            await Shell.Current.GoToAsync($"///{nameof(DashboardPage)}", true);
        }
        else
        {
            Console.WriteLine("Use PushPop");
            var page = serviceProvider.GetService<DashboardPage>();
            Shell.Current.Navigation.PushAsync(page);
        }
    }
}