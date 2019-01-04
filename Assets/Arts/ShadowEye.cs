using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowEye : Arts {

    private bool performed;

    public Sprite healSprite;

    public GameObject effect;

    public float percentBuff;
    private void Awake()
    {        
        GameObject newEffect = (GameObject)Instantiate(effect, GameObject.Find("ArtEffects").transform);
        Destroy(newEffect, animationTime);
       
    }

    // Update is called once per frame
    void FixedUpdate () {
        GameObject.FindObjectOfType<PlayerAnimator>().GetComponent<SpriteRenderer>().sprite = healSprite;
        anim.enabled = false;
        if (!performed)
        {
            PlayerPrefs.SetFloat("DMGBuff", percentBuff);
            performed = true;
        }
	}
}
