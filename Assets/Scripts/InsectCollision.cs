using UnityEngine;

public class InsectCollision : MonoBehaviour
{
    //creates a variable in the inspector for a scriptable object
    public InsectData insectData;

//function that can only be used by this class and its children
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //checks to see if there is a playerhealth component attached to player object
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            //insect class applies a certain of damage to player health
            if (playerHealth != null)
            {
                //passes damage info to the TakeDamage method
                playerHealth.TakeDamage(insectData.damage);
            }
        }
    }
}
