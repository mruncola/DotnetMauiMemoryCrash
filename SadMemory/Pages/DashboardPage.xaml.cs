using SadMemory.ViewModels;

namespace SadMemory.Pages;

public partial class DashboardPage : ContentPage
{
    public DashboardPage(DashboardPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}