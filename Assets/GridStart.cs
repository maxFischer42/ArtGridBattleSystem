﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStart : MonoBehaviour
{

    public void InstantiateGrid(Vector2 _startPosition, Vector2 _size, GridBox _box)
    {
        float x = _startPosition.x;
        float y = _startPosition.y;
        for (int a = Mathf.RoundToInt(y); a < _size.y; a++)
        {
            for (int i = Mathf.RoundToInt(x); i < _size.x; i++)
            {
                PlaceBox(new Vector2(i, a), _box);
            }
        }
    }

    public void PlaceBox(Vector2 _position, GridBox _box)
    {
        GameObject _object = new GameObject();
        _object.AddComponent<SpriteRenderer>();
        _object.GetComponent<SpriteRenderer>().sprite = _box.boxImage;
        _object.GetComponent<Transform>().localScale = _box.gridSize;
        GameObject _newBox = (GameObject)Instantiate(_object, _position, Quaternion.identity);
        GetComponent<GridManager>().grid.Add(_newBox);
    }
	


}