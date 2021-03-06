﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(GridStart))]
public class GridManager : MonoBehaviour {

    [Tooltip("The GridBox item that will make up the grid")]
    public GridBox gridBox;

    [Tooltip("The player cursor object.")]
    public GridBox playerBox;

    [Tooltip("The starting position from the parent to create the grid")]
    public Vector2 startPoint;

    private GridStart gridStart;
    public GameObject gridPlayer;

    [Tooltip("The location the player's cursor starts at on the grid.")]
    public Vector2 originPoint;

    public Vector2 gridSize;

    public List<GameObject> grid = new List<GameObject>();


    public void Start()
    {
        SetDefaults();
        gridStart.InstantiateGrid(startPoint, gridSize, gridBox);
    }

    public void SetDefaults()
    {
        gridStart = GetComponent<GridStart>();
    }

}
