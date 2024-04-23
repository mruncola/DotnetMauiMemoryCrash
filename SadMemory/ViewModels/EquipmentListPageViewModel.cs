using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SadMemory.Pages;

namespace SadMemory.ViewModels;

[QueryProperty("Location", "Location")]
public partial class EquipmentListPageViewModel(IServiceProvider serviceProvider): ObservableObject
{
    [ObservableProperty] private string _location = string.Empty;
    [ObservableProperty] private string _pageTitle = "Equipment List Page";

    [RelayCommand]
    private async Task GoBackPage()
    {
        var app = (App)Application.Current;
        if (app.UseGoto)
        {
            await Shell.Current.GoToAsync($"..", true);
        }
        else
        {
            Shell.Current.Navigation.PopAsync();
        }
    }
    [RelayCommand]
    private async Task GoDetailPage()
    {
        
        var app = (App)Application.Current;
        if (app.UseGoto)
        {
            var navigationParameter = new Dictionary<string, object> {
                { "Equipment", "Equipment1234" }
            };
            await Shell.Current.GoToAsync($"/{nameof(EquipmentDetailPage)}", true, navigationParameter);
        }
        else
        {
            Console.WriteLine("Use PushPop");
            var page = serviceProvider.GetService<EquipmentDetailPage>();
            var bc = (EquipmentDetailPageViewModel)page.BindingContext;
            bc.Equipment = "Equipment1234";
            Shell.Current.Navigation.PushAsync(page);
        }
    }
}