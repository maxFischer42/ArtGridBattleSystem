using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    private PlayerController play;

	// Use this for initialization
	void Start () {
        play = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 input = Vector2.zero;
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        play.checkMove(input);
    }
}
