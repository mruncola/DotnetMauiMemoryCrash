using SadMemory.ViewModels;

namespace SadMemory.Pages;

public partial class LocationPage : ContentPage
{
    public LocationPage(LocationPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}