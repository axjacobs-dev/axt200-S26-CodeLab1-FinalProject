using UnityEngine;

public class InsectCollision : MonoBehaviour
{
    public InsectData insectData;

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(insectData.damage);
            }
        }
    }
}
