using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    //speed of object
    public float speed = 2f;
    //how far object will move to the left
    public float rangeMin = -5f;
    //how far object will move to the right
    public float rangeMax = 5f;

   void Update()
    {
        //calculates how far object will travel and stores that value
        float rangeLength = rangeMax - rangeMin;
        //gets a value for x-position as the object moves between rangeMin and rangeMax
        float x = Mathf.PingPong(Time.time * speed, rangeLength) + rangeMin;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }

}
