using UnityEngine;

public class GoalScript : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        //when object collides with object carrying this component
        //game updates to next level
        //technically the insects could trigger this
        Debug.Log("Next level!");
        ASCIILevelLoader.instance.CurrentLevel++;
    }
}
