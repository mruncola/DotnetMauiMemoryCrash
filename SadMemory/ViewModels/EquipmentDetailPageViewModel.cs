using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

[QueryProperty("Equipment", "Equipment")]
public partial class EquipmentDetailPageViewModel: ObservableObject
{
    [ObservableProperty] private string _equipment = string.Empty;
    [ObservableProperty] private string _pageTitle = "Equipment Detail Page";

    [RelayCommand]
    private async Task GoBackPage()
    {
        await Shell.Current.GoToAsync($"..", true);
    }
}