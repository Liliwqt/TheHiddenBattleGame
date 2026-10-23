# The Hidden Battle Game

A 2-player WPF battleship-style strategy game built with C# and .NET 10.
Originally created as a school final project activity (2024) by Pamaybay, Hofer, and Pillado.

## Tech Stack

- **Language:** C#
- **Framework:** .NET 10 (Windows)
- **UI:** WPF (Windows Presentation Foundation)
- **Build:** Visual Studio 2022+

## Gameplay

1. **Strategy Phase** — Each player places their ships on a 20×20 grid:
   - 1× Battleship (6 blocks)
   - 2× Cruisers (4 blocks each)
   - 2× Submarines (3 blocks each)
   - 2× Destroyers (2 blocks each)
   - Ships must be placed horizontally or vertically, without overlapping.

2. **Battle Phase** — Players take turns attacking cells on the opponent's grid:
   - Hit a ship → damage it and gain power bar
   - Miss → gain a smaller amount of power bar
   - Destroy all blocks of a ship → it is eliminated
   - Reduce the opponent's life bar to 0 → win the round
   - First to 2 round wins wins the stage; first to win 12 stages wins the game

3. **Power-ups** (spend power bar to activate):
   - **Radar Scan** — Reveals a 3×3 area
   - **Double Shot** — Attack two cells in one turn
   - **Triple Shot** — Attack three cells in one turn
   - **Lucky Shot** — Randomly attacks an unknown enemy cell

## Project Status

⚠️ **This is a decompiled reconstruction.** The original source was compiled into a DLL; this repo contains the decompiled C# code. XAML files and image resources need to be recreated for a full Visual Studio build.

- ✅ Game logic fully recovered (GameState, Player, GameObject, PowerUp, combat, power-ups)
- ❌ No unit tests
- ❌ XAML UI files missing (need to be recreated)
- ❌ Image assets missing (need to be recreated)
- ⚠️ Needs improvements and testing before production use

## How to Build

1. Open `TheHiddenBattleGame.csproj` in Visual Studio 2022+
2. Ensure the .NET 10.0 Windows SDK is installed
3. Recreate the XAML files and image assets referenced in the code
4. Press F5 to run

## Authors

- Pamaybay
- Hofer
- Pillado

## License

MIT License — see [LICENSE](LICENSE) for details.
