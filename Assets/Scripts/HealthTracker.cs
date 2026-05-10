using UnityEngine;
using TMPro;

public class HealthTracker : MonoBehaviour
{
    //variable for UI text recording health
    public TextMeshProUGUI healthText;
    //reference to playerdata scriptable object
    public PlayerData playerData;

    void Update()
    {
        //updates health text with current health
        healthText.text = "Health: " + playerData.currentHealth;
    }
}
