using UnityEngine;

public class SpiderCollision : InsectCollision
{
    public SpiderData spiderData;
    public GameStats gameStats;
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                gameStats.spidersTouched++;
                int escalatingDamage = spiderData.damage + ASCIILevelLoader.instance.resetCount;
                playerHealth.TakeDamage(escalatingDamage);
            }
        }
    }
}