using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

[QueryProperty("Location", "Location")]
public partial class EquipmentListPageViewModel: ObservableObject
{
    [ObservableProperty] private string _location = string.Empty;
    [ObservableProperty] private string _pageTitle = "Equipment List Page";

    [RelayCommand]
    private async Task GoBackPage()
    {
        await Shell.Current.GoToAsync($"..", true);
    }
    [RelayCommand]
    private async Task GoDetailPage()
    {
        var navigationParameter = new Dictionary<string, object> {
            { "Equipment", "Equipment1234" }
        };
        await Shell.Current.GoToAsync($"/{nameof(EquipmentDetailPage)}", true, navigationParameter);
    }
}