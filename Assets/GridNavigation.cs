using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNavigation : MonoBehaviour {

    private List<GameObject> boxes = new List<GameObject>();

    public void Setup(List<GameObject> _boxList, Vector2 _origin)
    {
        boxes = _boxList;
	}
}
