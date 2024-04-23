using SadMemory.ViewModels;

namespace SadMemory.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}