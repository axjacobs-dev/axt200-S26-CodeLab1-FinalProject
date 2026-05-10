using UnityEngine;
using TMPro;

public class StatsTracker : MonoBehaviour
{
    public TextMeshProUGUI totalResetsText;
    public TextMeshProUGUI totalDamageTakenText;
    public TextMeshProUGUI spidersTouchedText;
    public GameStats gameStats;

    void Update()
    {
        totalResetsText.text = "Resets: " + gameStats.totalResets;
        spidersTouchedText.text = "Spiders Touched: " + gameStats.spidersTouched;
        totalDamageTakenText.text = "Total Damage: " + gameStats.totalDamageTaken;
    }
}
