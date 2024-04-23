using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

public partial class MainPageViewModel(IServiceProvider serviceProvider): ObservableObject
{
    [ObservableProperty] private string _pageTitle = "Main Page";
    [ObservableProperty] private bool _usingGoto = true;
    

    [RelayCommand]
    private async Task GoNextPage()
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

    [RelayCommand]
    private void SwitchGoto()
    {
        var app = (App)Application.Current;
        app.UseGoto = true;
        UsingGoto = true;
    }
    [RelayCommand]
    private void SwitchPushPop()
    {
        var app = (App)Application.Current;
        app.UseGoto = false;
        UsingGoto = false;
    }
}