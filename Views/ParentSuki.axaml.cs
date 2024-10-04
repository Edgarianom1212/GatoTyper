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
			this.BackgroundStyle = SukiUI.Enums.SukiBackgroundStyle.Gradient;
			SukiTheme.GetInstance().ChangeColorTheme(new SukiColorTheme("Black", Colors.Black, Colors.Black));
		}
	}
}