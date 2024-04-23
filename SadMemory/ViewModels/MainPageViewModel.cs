using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

public partial class MainPageViewModel: ObservableObject
{
    [ObservableProperty] private string _pageTitle = "Main Page";

    [RelayCommand]
    private async Task GoNextPage()
    {
        await Shell.Current.GoToAsync($"///{nameof(DashboardPage)}", true);
    }
}