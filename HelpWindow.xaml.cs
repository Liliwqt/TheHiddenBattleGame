using System.Windows;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado
{
	public partial class HelpWindow : Window
	{
		public HelpWindow()
		{
			InitializeComponent();
		}

		public void InitializeComponent()
		{
			// XAML is loaded by the WPF framework at runtime
		}

		private void CloseBtn_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		void IComponentConnector.Connect(int connectionId, object target)
		{
			// XAML connector - implemented by generated code
		}
	}
}