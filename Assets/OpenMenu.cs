using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenMenu : MonoBehaviour {

    public bool isOpen = false;
    public bool moving;
    public float countTo;
    public float timer;
    public GameObject Button;
    public RectTransform rect;

	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape) && !moving)
        {
            EventSystem.current.SetSelectedGameObject(Button);
            isOpen = !isOpen;
            moving = true;
        }
        if (moving)
        {
            timer++;
            if (isOpen)
            {
                rect.Translate(new Vector2(-10f, 0f));
                if(timer >= countTo)
                {
                    timer = 0;
                    moving = false;
                }
            }
            else if (!isOpen)
            {
                rect.Translate(new Vector2(10f, 0f));
                if (timer >= countTo)
                {
                    timer = 0;
                    moving = false;
                }
            }

        }
	}
}
