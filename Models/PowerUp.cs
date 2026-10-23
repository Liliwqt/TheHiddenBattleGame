using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinalProject_TheHiddenBattleGame_Pamaybay_Hofer_Pillado.Models
{
	public class PowerUp : INotifyPropertyChanged
	{
		private string _name = string.Empty;
		private string _description = string.Empty;
		private int _powerCost;
		private int _moves;

		public string Name
		{
			get => _name;
			set { _name = value; OnPropertyChanged("Name"); }
		}

		public string Description
		{
			get => _description;
			set { _description = value; OnPropertyChanged("Description"); }
		}

		public int PowerCost
		{
			get => _powerCost;
			set { _powerCost = value; OnPropertyChanged("PowerCost"); }
		}

		public int Moves
		{
			get => _moves;
			set { _moves = value; OnPropertyChanged("Moves"); }
		}

		public PowerUpType Type { get; set; }

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public static List<PowerUp> GetPowerUps()
		{
			return new List<PowerUp>
			{
				new PowerUp { Name = "Radar Scan", Description = "Reveals a 3x3 area", PowerCost = 3, Moves = 1, Type = PowerUpType.RadarScan },
				new PowerUp { Name = "Double Shot", Description = "Attack two cells", PowerCost = 4, Moves = 2, Type = PowerUpType.DoubleShot },
				new PowerUp { Name = "Triple Shot", Description = "Attack three cells", PowerCost = 6, Moves = 3, Type = PowerUpType.TripleShot },
				new PowerUp { Name = "Missile Barrage", Description = "Attack a 2x2 area", PowerCost = 5, Moves = 4, Type = PowerUpType.MissileBarrage },
				new PowerUp { Name = "Air Strike", Description = "Attack entire row", PowerCost = 8, Moves = 20, Type = PowerUpType.AirStrike },
				new PowerUp { Name = "Torpedo", Description = "Attack entire column", PowerCost = 8, Moves = 20, Type = PowerUpType.Torpedo },
				new PowerUp { Name = "Lucky Shot", Description = "Guaranteed hit on enemy", PowerCost = 10, Moves = 1, Type = PowerUpType.LuckyShot }
			};
		}
	}
}