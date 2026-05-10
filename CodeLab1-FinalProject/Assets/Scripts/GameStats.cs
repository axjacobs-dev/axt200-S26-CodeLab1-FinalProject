using UnityEngine;

[CreateAssetMenu(fileName = "GameStats", menuName = "Scriptable Objects/GameStats")]
public class GameStats : ScriptableObject
{
    public int totalResets;
    public int totalDamageTaken;
    public int spidersTouched;

    public void ResetStats()
    {
        totalResets = 0;
        totalDamageTaken = 0;
        spidersTouched = 0;
    }
}
