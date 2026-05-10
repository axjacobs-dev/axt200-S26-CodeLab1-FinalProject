using UnityEngine;

public class SpiderCollision : InsectCollision
{
    //variables for scriptable object references
    public SpiderData spiderData;
    public GameStats gameStats;

    //using override because parent class also uses ontrigger enter
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //checks to see if there is a playerhealth component on the player object
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                //if player still has health touching the spiders will increase damage received
                //increases counter by one each time player touches a spider
                gameStats.spidersTouched++;
                //adds reset number to base damage, each time level resets the damage increases
                int escalatingDamage = spiderData.damage + ASCIILevelLoader.instance.resetCount;
                //passes info into TakeDamage method
                playerHealth.TakeDamage(escalatingDamage);
            }
        }
    }
}