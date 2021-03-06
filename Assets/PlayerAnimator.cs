﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    public Animator anim;
    public Rigidbody rigid;
    public SpriteRenderer sprite;
    public RuntimeAnimatorController Idle;
    public RuntimeAnimatorController sideWalk;
    public RuntimeAnimatorController downWalk;
    public RuntimeAnimatorController upWalk;

    public bool usingArt = false;

    public void Update()
    {
        if (Time.timeScale == 0)
            return;
        if (usingArt)
            return;


        RuntimeAnimatorController animation = Idle;


        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (rigid.velocity.x > 0)
            {
                animation = sideWalk;
                sprite.flipX = false;
            }
            else if (rigid.velocity.x < 0)
            {
                animation = sideWalk;
                sprite.flipX = true;
            }
        }
        if(Input.GetAxisRaw("Vertical") != 0)
        {
            if (rigid.velocity.z < 0)
            {
                animation = downWalk;
                sprite.flipX = false;
            }
            else if (rigid.velocity.z > 0)
            {
                animation = upWalk;
                sprite.flipX = true;
            }
        }


        Debug.Log(rigid.velocity);
        anim.runtimeAnimatorController = animation;
    }

}
