using UnityEngine;


public class PingPongMovement : MonoBehaviour
{
    public CicadaData cicadaData;
    // //speed of object
    // public float speed = 2f;
    // //how far object will move to the left
    // public float rangeMin = -5f;
    // //how far object will move to the right
    // public float rangeMax = 5f;
    //no longer needs the info above because it is pulling that from the scriptable object

    void Update()
    {
        //calculates how far object will travel and stores that value
        float rangeLength = cicadaData.rangeMax - cicadaData.rangeMin;
        //gets a value for x-position as the object moves between rangeMin and rangeMax
        float x = Mathf.PingPong(Time.time * cicadaData.speed, rangeLength) + cicadaData.rangeMin;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
