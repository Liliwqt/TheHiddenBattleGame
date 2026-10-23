using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado.Models;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado
{
	public partial class LoadingWindow : Window
	{
		private readonly GameState _gameState;
		private readonly int _duration;
		private int _countdown;
		private DispatcherTimer? _timer;
		private readonly bool _goToStrategy;

		public LoadingWindow(GameState gameState, int durationSeconds, bool goToStrategy = true)
		{
			_gameState = gameState;
			_duration = durationSeconds;
			_countdown = durationSeconds;
			_goToStrategy = goToStrategy;
			InitializeComponent();
			UpdateDisplay();
			StartCountdown();
		}

		public void InitializeComponent()
		{
			// XAML is loaded by the WPF framework at runtime
		}

		private void UpdateDisplay()
		{
			// Update stage, round, message, and countdown text
		}

		private void StartCountdown()
		{
			_timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
			_timer.Tick += Timer_Tick;
			_timer.Start();
		}

		private void Timer_Tick(object? sender, EventArgs e)
		{
			_countdown--;
			if (_countdown <= 0)
			{
				_timer.Stop();
				TransitionToGame();
			}
		}

		private void TransitionToGame()
		{
			new GameWindow(_gameState).Show();
			Close();
		}

		void IComponentConnector.Connect(int connectionId, object target)
		{
			// XAML connector - implemented by generated code
		}
	}
}