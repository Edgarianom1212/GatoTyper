using Avalonia.Controls;
using Avalonia.Media;
using SukiUI;
using SukiUI.Controls;
using SukiUI.Models;

namespace GatoTyper.Views
{
	public partial class ParentSuki : SukiWindow
	{
		public ParentSuki()
		{
			InitializeComponent();
			var BlackTheme = new SukiColorTheme("Black", Colors.Black, Colors.Black);
			SukiTheme.GetInstance().AddColorTheme(BlackTheme);
			SukiTheme.GetInstance().ChangeColorTheme(BlackTheme);
		}
	}
}