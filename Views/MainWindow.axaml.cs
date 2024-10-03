using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Styling;
using GatoTyper.ViewModels;
using SukiUI;
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

		SwitchIconColor();

		SukiTheme.GetInstance().OnBaseThemeChanged += variant => SwitchIconColor();
	}

	private void SwitchIconColor()
	{
		if (SukiTheme.GetInstance().ActiveBaseTheme == ThemeVariant.Dark)
		{
			vm.SideMenuIconColor = new SolidColorBrush(Colors.White);
			vm.SideMenuIconColorReversed = new SolidColorBrush(Colors.Black);
		}
		else
		{
			vm.SideMenuIconColor = new SolidColorBrush(Colors.Black);
			vm.SideMenuIconColorReversed = new SolidColorBrush(Colors.White);
		}
	}
}