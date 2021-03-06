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
                Debug.Log("Added box at ( " + i + " , " + a + " )");
            }
        }
    }

    public void PlaceBox(Vector2 _position, GridBox _box)
    {
        GameObject _object = new GameObject();
        _object.AddComponent<Grid>();
        _object.GetComponent<Grid>().currentPosition = _position;
        _object.AddComponent<SpriteRenderer>();
        _object.GetComponent<SpriteRenderer>().sprite = _box.boxImage;
        _object.GetComponent<SpriteRenderer>().color = _box.gridColor;
        _object.GetComponent<Transform>().localScale = _box.gridSize;
        GameObject _newBox = (GameObject)Instantiate(_object, transform);
        _newBox.name = "( " + _position.x + " , " + _position.y + " )";
        _newBox.transform.SetPositionAndRotation(_position, Quaternion.identity);
        Destroy(_object);
        GetComponent<GridManager>().grid.Add(_newBox);
    }
	


}
