using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EArt : ScriptableObject {

    public string artName;
    public float cooldown;
    public enum artType {Offensive, Defensive, Support };
    public artType m_artType;
    public GameObject hitBox;
    public GameObject warning;
    public int value;
    public float warningTime;
    public float animationTime;


    public void UseArt(Transform user)
    {
        GameObject hB = (GameObject)Instantiate(hitBox,user);
        Destroy(hB, 1f);
    }
}
