using UnityEngine;

[CreateAssetMenu(menuName = "Insects/Cicada")]
public class CicadaData : InsectData
{
    //variables held only by the cicada data scriptable object
    //child of insect data
    public float rangeMin = -5f;
    public float rangeMax = 5f;
}
