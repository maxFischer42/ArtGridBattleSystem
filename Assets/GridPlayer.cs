using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlayer : MonoBehaviour
{
    public Vector2 currentPos;
    public Vector2 north;
    public Vector2 east;
    public Vector2 south;
    public Vector2 west;

    private GridManager gridManager;

    public void Start()
    {
        gridManager = GameObject.FindObjectOfType<GridManager>().GetComponent<GridManager>();
        currentPos = gridManager.originPoint;
       
    }


       

}
