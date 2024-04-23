using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

public partial class DashboardPageViewModel: ObservableObject
{
    [ObservableProperty] private string _pageTitle = "Dashboard Page";

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