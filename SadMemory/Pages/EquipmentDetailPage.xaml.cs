using SadMemory.ViewModels;

namespace SadMemory.Pages;

public partial class EquipmentDetailPage : ContentPage
{
    public EquipmentDetailPage(EquipmentDetailPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}