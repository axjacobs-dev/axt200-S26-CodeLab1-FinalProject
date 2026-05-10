using UnityEngine;

public class RestartGame : MonoBehaviour
{
    //reference to gamestats scriptable object
    public GameStats gameStats;

    public void StartOver()
    {
        //calling resetstats method
        gameStats.ResetStats();
        //resets health to max, resets counter set to 0, resets game level to 0
        ASCIILevelLoader.instance.playerData.ResetHealth();
        ASCIILevelLoader.instance.resetCount = 0;
        ASCIILevelLoader.instance.CurrentLevel = 0;
    }
}