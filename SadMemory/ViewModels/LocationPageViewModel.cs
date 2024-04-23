using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

public partial class LocationPageViewModel(IServiceProvider serviceProvider): ObservableObject
{
    [ObservableProperty] private string _pageTitle = "Location Page";

    [RelayCommand]
    private async Task GoEquipmentListPage()
    {
        var app = (App)Application.Current;
        if (app.UseGoto)
        {
            var navigationParameter = new Dictionary<string, object> {
                { "Location", "Location1234" }
            };
            await Shell.Current.GoToAsync($"/{nameof(EquipmentListPage)}", true, navigationParameter);
        }
        else
        {
            Console.WriteLine("Use PushPop");
            var page = serviceProvider.GetService<EquipmentListPage>();
            var bc = (EquipmentListPageViewModel)page.BindingContext;
            bc.Location = "Location1234";
            Shell.Current.Navigation.PushAsync(page);
        }
    }
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