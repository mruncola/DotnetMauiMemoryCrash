using SadMemory.ViewModels;

namespace SadMemory.Pages;

public partial class EquipmentListPage : ContentPage
{
    public EquipmentListPage(EquipmentListPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}