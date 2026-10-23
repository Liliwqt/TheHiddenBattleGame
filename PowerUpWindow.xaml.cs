using System.Windows;
using System.Windows.Controls;
using FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado.Models;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado
{
	public partial class PowerUpWindow : Window
	{
		private readonly Player _player;

		public PowerUp? SelectedPowerUp { get; private set; }

		public PowerUpWindow(Player player)
		{
			_player = player;
			InitializeComponent();
			LoadPowerUps();
			UpdatePowerDisplay();
		}

		public void InitializeComponent()
		{
			// XAML is loaded by the WPF framework at runtime
		}

		private void LoadPowerUps()
		{
			// Power-up grid populated from PowerUp.GetPowerUps()
		}

		private void UpdatePowerDisplay()
		{
			// Update power bar display
		}

		private void UseBtn_Click(object sender, RoutedEventArgs e)
		{
			// Handle use power-up button click
		}

		private void BackBtn_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}

		void IComponentConnector.Connect(int connectionId, object target)
		{
			// XAML connector - implemented by generated code
		}
	}
}