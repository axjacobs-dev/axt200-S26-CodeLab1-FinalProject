using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public GameStats gameStats;

    public void StartOver()
    {
        gameStats.ResetStats();
        ASCIILevelLoader.instance.playerData.ResetHealth();
        ASCIILevelLoader.instance.resetCount = 0;
        ASCIILevelLoader.instance.CurrentLevel = 0;
    }
}