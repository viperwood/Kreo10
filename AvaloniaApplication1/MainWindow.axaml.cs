using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.X11;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        NewWindow taskWindow = new NewWindow();
        taskWindow.Show(); //Команда выводящая на экран
    }
}