using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //reference to scriptable object
    public PlayerData playerData;
    public GameStats gameStats;

    void Start()
    {
        //sets health to max health at start of game
        //playerData.ResetHealth();
    }

    void Update()
    {
        //if player falls below y pos level resets
        //health does not reset
        if (transform.position.y < -10f)
        {
            ASCIILevelLoader.instance.resetCount++;
            gameStats.totalResets++;
            ASCIILevelLoader.instance.CurrentLevel = ASCIILevelLoader.instance.CurrentLevel;
        }
    } 

    public void TakeDamage(int amount)
    {
        playerData.currentHealth -= amount;
        gameStats.totalDamageTaken += amount;
        Debug.Log("Health: " + playerData.currentHealth);

        if (playerData.currentHealth <= 0)
        {
            Debug.Log("the player is dead");
            //game over logic 
            //resets game if player dies
            //resets health
            gameStats.totalResets++;
            ASCIILevelLoader.instance.playerData.ResetHealth();
            ASCIILevelLoader.instance.CurrentLevel = 0;
        }
    }
}
