using UnityEngine;

public class CicadaPlatformMovement : MonoBehaviour
{
    public float speed = 2f;
    public float endX = -7f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= endX)
        {
            Destroy(gameObject);
        }
    }
}
