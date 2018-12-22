using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitDestroy : MonoBehaviour {

    private float timer;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Update()
    {
        timer++;
        if(timer > 75)
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}
