using UnityEngine;

[CreateAssetMenu(fileName = "InsectData", menuName = "Scriptable Objects/InsectData")]
public class InsectData : ScriptableObject
{
    //sets speed and damage for insect data scriptable object
    //insect data is a parent class
    public float speed = 2f;
    public int damage = 10;
}
