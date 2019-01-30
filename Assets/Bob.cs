using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour {

    public Vector3 newDirection;
    private Vector3 origin;
    public float timer;
    public bool isOrigin;
    public float time;
    public float var = 1;

	// Use this for initialization
	void Start ()
    {
        origin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        Vector3 direction = Vector3.zero;
        if(isOrigin)
        {
            transform.Translate(0, -var, 0);
        }
        else
        {
            transform.Translate(0, var, 0);
        }
        if(timer > time)
        {
            isOrigin = !isOrigin;
            timer = 0;
        }
        GetComponent<Rigidbody>().velocity = direction;
	}
}
