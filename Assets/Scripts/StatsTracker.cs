using UnityEngine;
using TMPro;

public class StatsTracker : MonoBehaviour
{
    //UI variables for game stats 
    public TextMeshProUGUI totalResetsText;
    public TextMeshProUGUI totalDamageTakenText;
    public TextMeshProUGUI spidersTouchedText;
    //variable that tracks stats across playthroughs
    public GameStats gameStats;

    void Update()
    {
        //these reset the UI text with updated stat info
        totalResetsText.text = "Resets: " + gameStats.totalResets;
        spidersTouchedText.text = "Spiders Touched: " + gameStats.spidersTouched;
        totalDamageTakenText.text = "Total Damage: " + gameStats.totalDamageTaken;
    }
}
