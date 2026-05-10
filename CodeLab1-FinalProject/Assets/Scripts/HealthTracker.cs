using UnityEngine;
using TMPro;

public class HealthTracker : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public PlayerData playerData;

    void Update()
    {
        healthText.text = "Health: " + playerData.currentHealth;
    }
}
