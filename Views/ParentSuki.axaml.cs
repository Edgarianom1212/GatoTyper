using Avalonia.Controls;
using Avalonia.Media;
using SukiUI;
using SukiUI.Controls;
using SukiUI.Models;
using System.Linq;

namespace GatoTyper.Views
{
	public partial class ParentSuki : SukiWindow
	{
		public ParentSuki()
		{
			InitializeComponent();
			this.BackgroundStyle = SukiUI.Enums.SukiBackgroundStyle.Gradient;
			SukiColorTheme BlackTheme = new SukiColorTheme("Black", Colors.White, Colors.Black);
			SukiTheme.GetInstance().ChangeColorTheme(BlackTheme);
		}
	}
}