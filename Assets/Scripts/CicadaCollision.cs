using UnityEngine;

//this is a child class

public class CicadaCollision : InsectCollision
{
    //this is a child class
    //when player object collides with the cicada it takes the damage set in the insectdata scriptable object
    //using oncollisionenter because player can use cicada as a moving platform at some health cost
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //checks to see if there is a playerhealth component on the player object
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                //passes damage info into this method
                playerHealth.TakeDamage(insectData.damage);
            }
        }
    }
}