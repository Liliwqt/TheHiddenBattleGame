using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado.Models
{
	public class Player : INotifyPropertyChanged
	{
		private string _name = string.Empty;
		private string _gender = string.Empty;
		private int _avatarIndex;
		private string _chant = string.Empty;
		private int _points;
		private double _lifeBar = 100.0;
		private int _powerBar;
		private bool _isCurrentTurn;

		public string Name
		{
			get => _name;
			set { _name = value; OnPropertyChanged("Name"); }
		}

		public string Gender
		{
			get => _gender;
			set { _gender = value; OnPropertyChanged("Gender"); }
		}

		public int AvatarIndex
		{
			get => _avatarIndex;
			set { _avatarIndex = value; OnPropertyChanged("AvatarIndex"); }
		}

		public string Chant
		{
			get => _chant;
			set { _chant = value; OnPropertyChanged("Chant"); }
		}

		public int Points
		{
			get => _points;
			set { _points = value; OnPropertyChanged("Points"); }
		}

		public double LifeBar
		{
			get => _lifeBar;
			set { _lifeBar = value; OnPropertyChanged("LifeBar"); }
		}

		public int PowerBar
		{
			get => _powerBar;
			set { _powerBar = value; OnPropertyChanged("PowerBar"); }
		}

		public bool IsCurrentTurn
		{
			get => _isCurrentTurn;
			set { _isCurrentTurn = value; OnPropertyChanged("IsCurrentTurn"); }
		}

		public List<GameObject> GameObjects { get; set; } = new List<GameObject>();

		public bool[,] OccupiedCells { get; set; } = new bool[20, 20];

		public bool[,] HitCells { get; set; } = new bool[20, 20];

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void ResetForNewRound()
		{
			LifeBar = 100.0;
			PowerBar = 0;
			OccupiedCells = new bool[20, 20];
			HitCells = new bool[20, 20];
			foreach (GameObject gameObject in GameObjects)
			{
				gameObject.IsDeployed = false;
				gameObject.DestroyedBlocks = 0;
				gameObject.PlacedCells.Clear();
			}
		}

		public int GetTotalBlocks()
		{
			return GameObjects.Sum(o => o.BlockCount);
		}

		public int GetDestroyedBlocks()
		{
			return GameObjects.Sum(o => o.DestroyedBlocks);
		}

		public void UpdateLifeBar()
		{
			int totalBlocks = GetTotalBlocks();
			int destroyedBlocks = GetDestroyedBlocks();
			LifeBar = totalBlocks > 0
				? (double)(totalBlocks - destroyedBlocks) / (double)totalBlocks * 100.0
				: 0.0;
		}
	}
}