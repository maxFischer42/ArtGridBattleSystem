using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemy : ScriptableObject
{
    public string Name;
    public int level;
    public static StatCurve healthCurve;


}
