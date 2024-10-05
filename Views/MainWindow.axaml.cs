using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Styling;
using GatoTyper.ViewModels;
using SukiUI;
using SukiUI.Models;
using System;

namespace GatoTyper.Views;

public partial class MainWindow : UserControl
{
    public MainWindow()
    {
        InitializeComponent();
		DataContext = new MainWindowViewModel();
		vm = DataContext as MainWindowViewModel;
	}

	private MainWindowViewModel vm;

	protected override void OnLoaded(RoutedEventArgs e)
	{
		base.OnLoaded(e);

		HandleThemeChange();

		SukiTheme.GetInstance().OnBaseThemeChanged += variant => HandleThemeChange();
	}


	private void HandleThemeChange()
	{
		if (SukiTheme.GetInstance().ActiveBaseTheme == ThemeVariant.Dark)
		{
			vm.SideMenuIconColor = new SolidColorBrush(Colors.White);
			vm.SideMenuIconColorReversed = new SolidColorBrush(Colors.Black);
			Background = new SolidColorBrush(new Color(255, 30, 30, 30));
			if (SukiTheme.GetInstance()?.ActiveColorTheme?.DisplayName == "Black")
			{
				SukiColorTheme BlackTheme = new SukiColorTheme("Black", Colors.White, Colors.Black);
				SukiTheme.GetInstance().ChangeColorTheme(BlackTheme);
			}
		}
		else
		{
			vm.SideMenuIconColor = new SolidColorBrush(Colors.Black);
			vm.SideMenuIconColorReversed = new SolidColorBrush(Colors.White);
			Background = new SolidColorBrush(new Color(255, 232, 232, 232));
			if (SukiTheme.GetInstance()?.ActiveColorTheme?.DisplayName == "Black")
			{
				SukiColorTheme BlackTheme = new SukiColorTheme("Black", Colors.Black, Colors.Black);
				SukiTheme.GetInstance().ChangeColorTheme(BlackTheme);
			}
		}


	}
}