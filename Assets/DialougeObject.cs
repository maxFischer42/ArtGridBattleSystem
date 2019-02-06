using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DialougeObject : ScriptableObject
{

    public string Dialouge;
    public Color Color = Color.white;
    public int Size = 60;
    public int LineSpacing = 1;
    public float TypeSpeed = 0.1f;
	
}
