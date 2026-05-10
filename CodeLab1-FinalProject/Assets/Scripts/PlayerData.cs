using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public int maxHealth = 100;
    public int currentHealth;

    //this function is called when health resets which happens when game resets
    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
