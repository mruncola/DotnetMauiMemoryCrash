namespace SadMemory;

public partial class App : Application
{
    
    public bool UseGoto = false;
    
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}