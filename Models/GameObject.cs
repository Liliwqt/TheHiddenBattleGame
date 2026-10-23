using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado.Models
{
	public class GameObject : INotifyPropertyChanged
	{
		private string _name = string.Empty;
		private int _blockCount;
		private bool _isDeployed;
		private int _destroyedBlocks;
		private string _imagePath = string.Empty;

		public string Name
		{
			get => _name;
			set { _name = value; OnPropertyChanged("Name"); }
		}

		public int BlockCount
		{
			get => _blockCount;
			set { _blockCount = value; OnPropertyChanged("BlockCount"); }
		}

		public string ImagePath
		{
			get => _imagePath;
			set { _imagePath = value; OnPropertyChanged("ImagePath"); }
		}

		public bool IsDeployed
		{
			get => _isDeployed;
			set { _isDeployed = value; OnPropertyChanged("IsDeployed"); OnPropertyChanged("CanDeploy"); }
		}

		public bool CanDeploy => !IsDeployed;

		public int DestroyedBlocks
		{
			get => _destroyedBlocks;
			set { _destroyedBlocks = value; OnPropertyChanged("DestroyedBlocks"); OnPropertyChanged("IsDestroyed"); }
		}

		public bool IsDestroyed => DestroyedBlocks >= BlockCount;

		public List<(int Row, int Col)> PlacedCells { get; set; } = new List<(int, int)>();

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}