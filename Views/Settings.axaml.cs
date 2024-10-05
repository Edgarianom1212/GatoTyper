using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SukiUI.Enums;
using SukiUI;
using Avalonia.Styling;
using Avalonia.Media;
using SukiUI.Models;

namespace GatoTyper.Views;

public partial class Settings : UserControl
{
    public Settings()
    {
        InitializeComponent();
    }

	private void ColorOrange(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		SukiTheme.GetInstance().ChangeColorTheme(SukiColor.Orange);
	}
	private void ColorBlue(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		SukiTheme.GetInstance().ChangeColorTheme(SukiColor.Blue);
	}
	private void ColorRed(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		SukiTheme.GetInstance().ChangeColorTheme(SukiColor.Red);
	}
	private void ColorGreen(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		SukiTheme.GetInstance().ChangeColorTheme(SukiColor.Green);
	}
	private void ColorBlack(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		SukiTheme.GetInstance().ChangeColorTheme(new SukiColorTheme("Black", Colors.White, Colors.Black));
	}
	private void LightTheme(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		SukiTheme.GetInstance().ChangeBaseTheme(ThemeVariant.Light);
	}
	private void DarkTheme(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		SukiTheme.GetInstance().ChangeBaseTheme(ThemeVariant.Dark);
	}
}