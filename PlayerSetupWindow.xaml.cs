using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado.Models;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado
{
	public partial class PlayerSetupWindow : Window
	{
		private readonly string[] MaleAvatarNames = new string[10] { "Captain", "Admiral", "Sailor", "Pirate", "Navigator", "Commander", "Officer", "Gunner", "Helmsman", "Anchor" };
		private readonly string[] FemaleAvatarNames = new string[10] { "Captain", "Admiral", "Sailor", "Pirate", "Navigator", "Commander", "Officer", "Gunner", "Helmsman", "Anchor" };
		private readonly string[] MaleAvatarPaths = new string[10]
		{
			"/Images/male1.png", "/Images/male2.png", "/Images/male3.png", "/Images/male4.png", "/Images/male5.png",
			"/Images/male6.png", "/Images/male7.png", "/Images/male8.png", "/Images/male9.png", "/Images/male10.png"
		};
		private readonly string[] FemaleAvatarPaths = new string[10]
		{
			"/Images/female1.png", "/Images/female2.png", "/Images/female3.png", "/Images/female4.png", "/Images/female5.png",
			"/Images/female6.png", "/Images/female7.png", "/Images/female8.png", "/Images/female9.png", "/Images/female10.png"
		};

		public PlayerSetupWindow()
		{
			InitializeComponent();
			LoadAvatars();
		}

		public void InitializeComponent()
		{
			// XAML is loaded by the WPF framework at runtime
		}

		private void LoadAvatars()
		{
			UpdatePlayer1Avatars();
			UpdatePlayer2Avatars();
		}

		private void UpdatePlayer1Avatars()
		{
			// Avatar list population handled in XAML
		}

		private void UpdatePlayer2Avatars()
		{
			// Avatar list population handled in XAML
		}

		private void Player1GenderCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdatePlayer1Avatars();
		}

		private void Player2GenderCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdatePlayer2Avatars();
		}

		private void BackBtn_Click(object sender, RoutedEventArgs e)
		{
			new MenuWindow().Show();
			Close();
		}

		private void StartBattleBtn_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(((TextBox)FindName("Player1NameTxt")).Text) ||
				((TextBox)FindName("Player1NameTxt")).Text.Length < 4)
			{
				MessageBox.Show("Player 1 name must be at least 4 characters!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(((TextBox)FindName("Player2NameTxt")).Text) ||
				((TextBox)FindName("Player2NameTxt")).Text.Length < 4)
			{
				MessageBox.Show("Player 2 name must be at least 4 characters!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
				return;
			}

			var gameState = new GameState();
			gameState.InitializeGameObjects();
			gameState.Player1.Name = ((TextBox)FindName("Player1NameTxt")).Text;
			gameState.Player2.Name = ((TextBox)FindName("Player2NameTxt")).Text;
			gameState.Player1.Chant = "I got you!";
			gameState.Player2.Chant = "Take that!";

			new LoadingWindow(gameState, 3).Show();
			Close();
		}

		void IComponentConnector.Connect(int connectionId, object target)
		{
			// XAML connector - implemented by generated code
		}
	}
}