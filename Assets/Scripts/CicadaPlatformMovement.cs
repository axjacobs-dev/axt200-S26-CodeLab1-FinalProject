using UnityEngine;

public class CicadaPlatformMovement : MonoBehaviour
{
    //variables for speed and x-axis movement limit
    public float speed = 2f;
    public float endX = -7f;

    void Update()
    {
        //moves object to the left
        transform.position += Vector3.left * speed * Time.deltaTime;

        //if object with this component crosses a certain point on the x-axis
        //it is destroyed
        if (transform.position.x <= endX)
        {
            Destroy(gameObject);
        }
    }
}
