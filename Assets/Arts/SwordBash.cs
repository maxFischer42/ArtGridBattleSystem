using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBash : Arts {

    public RuntimeAnimatorController m_animation;
    private bool animationInit = false;
    public float timeToHitbox;
    private bool hasAttacked;
    public GameObject HitBox;
    public GameObject effect;
    public float percentHP = 5f;


    void Awake ()
    {
        GameObject newEffect = (GameObject)Instantiate(effect, GameObject.Find("ArtEffects").transform);
        Destroy(newEffect, animationTime);
    }
	
	void FixedUpdate () {
		if(!animationInit)
        {
            anim.runtimeAnimatorController = m_animation;
            animationInit = true;
        }
        if(timer >= timeToHitbox && !hasAttacked)
        {
            hasAttacked = true;
            HitBox.GetComponent<DamageCollider>().damage = percentHP;
            GameObject hitBoxSpawned = (GameObject)Instantiate(HitBox,GameObject.Find("Controller").transform);
            //Destroy(hitBoxSpawned, 0.016f);
            
        }

	}
}
