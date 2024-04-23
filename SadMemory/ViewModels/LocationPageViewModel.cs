using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

public partial class LocationPageViewModel: ObservableObject
{
    [ObservableProperty] private string _pageTitle = "Location Page";

    [RelayCommand]
    private async Task GoEquipmentListPage()
    {
        var navigationParameter = new Dictionary<string, object> {
            { "Location", "Location1234" }
        };
        await Shell.Current.GoToAsync($"/{nameof(EquipmentListPage)}", true, navigationParameter);
    }
    [RelayCommand]
    private async Task GoListPage()
    {
        await Shell.Current.GoToAsync($"///{nameof(LocationPage)}", true);
    }
    
    [RelayCommand]
    private async Task GoDashPage()
    {
        await Shell.Current.GoToAsync($"///{nameof(DashboardPage)}", true);
    }
}