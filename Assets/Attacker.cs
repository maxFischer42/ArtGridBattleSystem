using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    private Battle battle;
    private Enemy enemy;

    public float currentHP = 1;
    public float currentATK = 1;
    private float currentLvl;

	// Use this for initialization
	void Start ()
    {
        battle = GetComponent<Battle>();
        enemy = battle.myEnemy;
        currentLvl = enemy.level;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
