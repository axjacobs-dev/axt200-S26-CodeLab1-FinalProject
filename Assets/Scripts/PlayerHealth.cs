using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //references to scriptable objects
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
            //adds 1 to reset counter
            ASCIILevelLoader.instance.resetCount++;
            gameStats.totalResets++;
            ASCIILevelLoader.instance.CurrentLevel = ASCIILevelLoader.instance.CurrentLevel;
        }
    } 

    public void TakeDamage(int amount)
    {
        //subtracts damage from current health
        playerData.currentHealth -= amount;
        //adds that damage to game stat "total damage"
        gameStats.totalDamageTaken += amount;
        Debug.Log("Health: " + playerData.currentHealth);

        if (playerData.currentHealth <= 0)
        {
            Debug.Log("the player is dead");
            //game over logic 
            //resets game if player dies
            //resets health to max
            //adds 1 to reset counter
            gameStats.totalResets++;
            ASCIILevelLoader.instance.playerData.ResetHealth();
            ASCIILevelLoader.instance.CurrentLevel = 0;
        }
    }
}
