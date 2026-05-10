using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    public SpiderData spiderData;

    void Update()
    {
        transform.Rotate(0, spiderData.rotationSpeed * Time.deltaTime, 0);
    }
}
