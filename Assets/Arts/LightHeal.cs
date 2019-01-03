using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHeal : Arts {

    public float timeToHeal;
    public Vector2 healRange;
    private bool performed;

    public Sprite healSprite;

    public GameObject effect;

    private void Awake()
    {        
        GameObject newEffect = (GameObject)Instantiate(effect, GameObject.Find("ArtEffects").transform);
        Destroy(newEffect, animationTime);
       
    }

    // Update is called once per frame
    void FixedUpdate () {
        GameObject.FindObjectOfType<PlayerAnimator>().GetComponent<SpriteRenderer>().sprite = healSprite;
        anim.enabled = false;
        if (timer >= timeToHeal && !performed)
        {
            GameObject.FindObjectOfType<PlayerStats>().GetComponent<PlayerStats>().Heal(Random.Range(healRange.x, healRange.y));
            performed = true;
        }
	}
}
