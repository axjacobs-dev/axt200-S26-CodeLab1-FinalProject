using UnityEngine;

[CreateAssetMenu(fileName = "GameStats", menuName = "Scriptable Objects/GameStats")]
public class GameStats : ScriptableObject
{
    //this scriptable object holds variables for game stats like resets, total damage
    //and number of spiders touched
    public int totalResets;
    public int totalDamageTaken;
    public int spidersTouched;

    //when it is called this method resets these counters to 0
    public void ResetStats()
    {
        totalResets = 0;
        totalDamageTaken = 0;
        spidersTouched = 0;
    }
}
