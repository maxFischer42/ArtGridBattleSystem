using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour {

    public float cooldown;
    public bool isUsed;
    private float timer;
	
	// Update is called once per frame
	void Update ()
    {
		if(isUsed)
        {
            timer += Time.deltaTime;
            if(timer >= cooldown)
            {
                GetComponent<Button>().interactable = true;
                timer = 0f;
                isUsed = false;
                transform.GetComponent<RectTransform>().sizeDelta = new Vector2(200,200);
                return;
            }
            transform.GetComponent<RectTransform>().sizeDelta = new Vector2(200, (timer / cooldown) * 200);

        }
	}
}
