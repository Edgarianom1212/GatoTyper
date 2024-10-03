using Avalonia.Media;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoTyper.ViewModels
{
	internal class MainWindowViewModel : ViewModelBase
	{
		private SolidColorBrush sideMenuColorBrush;
		public SolidColorBrush SideMenuIconColor
		{
			get => sideMenuColorBrush;
			set => this.RaiseAndSetIfChanged(ref sideMenuColorBrush, value);
		}

		private SolidColorBrush sideMenuColorBrushReversed;
		public SolidColorBrush SideMenuIconColorReversed
		{
			get => sideMenuColorBrushReversed;
			set => this.RaiseAndSetIfChanged(ref sideMenuColorBrushReversed, value);
		}


	}
}
