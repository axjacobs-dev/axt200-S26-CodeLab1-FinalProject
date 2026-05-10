using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    //reference to spider data scriptable object
    public SpiderData spiderData;

    void Update()
    {
        //rotation movement with speed set in spider data SO
        transform.Rotate(0, spiderData.rotationSpeed * Time.deltaTime, 0);
    }
}
