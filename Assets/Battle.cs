using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour {

    public enum BattleConditions {Friendly, Neutral, Aggresive, Reinforcements };
    public BattleConditions condition;
    public float conditionRange;

    public GameObject[] bounds;
    public GameObject Player;

    private bool inBattle = false;
    public AudioSource musicPlayer;
    public AudioClip battleTheme;

    public Enemy myEnemy;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(!inBattle)
        {
            Vector3 distanceToPlayer = transform.position - Player.transform.position;
            if(Mathf.Abs(distanceToPlayer.x) <= conditionRange && Mathf.Abs(distanceToPlayer.z) <= conditionRange)
            {
                if(condition == BattleConditions.Aggresive)
                { 
                    BattleSetup();
                }
            }
        }





	}

    void BattleSetup()
    {
        inBattle = true;
        Bounds(true);
        PlaySong(battleTheme);
        GameObject.Find("OverworldMenu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("BattleMenu").GetComponent<Canvas>().enabled = true;
    }

    void PlaySong(AudioClip audio)
    {
        musicPlayer.PlayOneShot(battleTheme);
    }




    //sets or unsets the fighting bounds for the battle
    void Bounds(bool state)
    {
        for(int i = 0; i < bounds.Length; i++)
        {
            bounds[i].SetActive(state);
        }
    }
}
