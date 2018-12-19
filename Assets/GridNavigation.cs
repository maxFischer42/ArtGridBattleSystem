using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNavigation : MonoBehaviour {

    private List<GameObject> boxes = new List<GameObject>();

    public GameObject currentFocus;
    public GridBox cursor;

    public void Setup(List<GameObject> _boxList, Vector2 _origin)
    {
        Debug.Log("Setting up player info");
        currentFocus = null;
        boxes = _boxList;
        cursor = GetComponent<GridManager>().playerBox;
        SetPosition(_origin);
	}

    public void SetPosition(Vector2 position)
    {
        Debug.Log("Setting new position");
        Grid[] _array = GameObject.FindObjectsOfType<Grid>();
        for(int i = 0; i < _array.Length; i++)
        {
            if(position == _array[i].currentPosition)
            {
                _array[i].gridBox = cursor;
                if(currentFocus)
                {
                    currentFocus.GetComponent<Grid>().gridBox = GetComponent<GridManager>().gridBox;
                    currentFocus = _array[i].gameObject;
                }
                break;
            }
        }
    }


}
