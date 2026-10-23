using System.Collections.Generic;
using System.Linq;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado.Models
{
	public class GameState
	{
		public Player Player1 { get; set; } = new Player();
		public Player Player2 { get; set; } = new Player();

		public int CurrentStage { get; set; } = 1;
		public int CurrentRound { get; set; } = 1;
		public int Player1RoundWins { get; set; }
		public int Player2RoundWins { get; set; }

		public GamePhase CurrentPhase { get; set; }
		public bool IsPlayer1Turn { get; set; }

		public bool IsGameComplete => CurrentStage > 12;

		public void InitializeGameObjects()
		{
			Player1.GameObjects = CreateGameObjects();
			Player2.GameObjects = CreateGameObjects();
		}

		private List<GameObject> CreateGameObjects()
		{
			return new List<GameObject>
			{
				new GameObject { Name = "Battleship", BlockCount = 6, ImagePath = "/Images/Ship/battleship.png" },
				new GameObject { Name = "Cruiser A", BlockCount = 4, ImagePath = "/Images/Ship/cruiser.png" },
				new GameObject { Name = "Cruiser B", BlockCount = 4, ImagePath = "/Images/Ship/cruiser.png" },
				new GameObject { Name = "Submarine A", BlockCount = 3, ImagePath = "/Images/Ship/submarine.png" },
				new GameObject { Name = "Submarine B", BlockCount = 3, ImagePath = "/Images/Ship/submarine.png" },
				new GameObject { Name = "Destroyer A", BlockCount = 2, ImagePath = "/Images/Ship/destroyer.png" },
				new GameObject { Name = "Destroyer B", BlockCount = 2, ImagePath = "/Images/Ship/destroyer.png" }
			};
		}

		public void ResetForNewRound()
		{
			Player1.ResetForNewRound();
			Player2.ResetForNewRound();
			CurrentPhase = GamePhase.Strategy;
			IsPlayer1Turn = false;
		}

		public void NextRound()
		{
			CurrentRound++;
			if (CurrentRound > 3)
			{
				if (Player1RoundWins > Player2RoundWins)
					Player1.Points++;
				else if (Player2RoundWins > Player1RoundWins)
					Player2.Points++;

				CurrentStage++;
				CurrentRound = 1;
				Player1RoundWins = 0;
				Player2RoundWins = 0;
			}
			ResetForNewRound();
		}

		public string GetWinner()
		{
			if (Player1.Points > Player2.Points)
				return Player1.Name;
			if (Player2.Points > Player1.Points)
				return Player2.Name;
			return "It's a tie!";
		}
	}
}