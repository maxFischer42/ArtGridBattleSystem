using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float maxHP = 550;
    public float currentHealth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Heal(float variable)
    {
        currentHealth += variable;
        if (currentHealth > maxHP)
            currentHealth = maxHP;
    }
}
