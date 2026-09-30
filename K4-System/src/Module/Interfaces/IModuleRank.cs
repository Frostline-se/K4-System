using K4System.Models;
using static K4System.ModuleRank;

namespace K4System;

public interface IModuleRank
{
	public void Initialize(bool hotReload);

	public void Release(bool hotReload);

	public Rank GetNoneRank();

	public void BeforeRoundEnd(int winnerTeam);

	public Rank GetPlayerRank(int points);

	public void UpdatePlayerRank(K4Player k4player);
}
