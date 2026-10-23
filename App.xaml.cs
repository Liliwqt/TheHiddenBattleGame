using System.Windows;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado
{
	public partial class App : Application
	{
		[STAThread]
		public static void Main()
		{
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}

		public void InitializeComponent()
		{
			StartupUri = new System.Uri("SplashWindow.xaml", System.UriKind.Relative);
		}
	}
}