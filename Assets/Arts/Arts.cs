using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arts : MonoBehaviour {

    public enum ArtType { Damage, Defense, Support};
    public Vector2 limits = new Vector2(1, 50);
    public ArtType ArtVariant;
    public float animationTime = 3f;
    public float timer;


    private PlayerMotor motor;
    private PlayerController control;
    private PlayerAnimator animator;
    public Animator anim;

    public void Start()
    {
        motor = GameObject.FindObjectOfType<PlayerMotor>().GetComponent<PlayerMotor>();
        control = GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
        animator = GameObject.FindObjectOfType<PlayerAnimator>().GetComponent<PlayerAnimator>();
        anim = GameObject.FindObjectOfType<PlayerAnimator>().GetComponent<Animator>();
        GameObject.FindObjectOfType<PlayerBattle>().GetComponent<PlayerBattle>().CanUse = false;
        motor.enabled = false;
        control.enabled = false;
        animator.enabled = false;
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if(timer >= animationTime)
        {

            GameObject.FindObjectOfType<PlayerBattle>().GetComponent<PlayerBattle>().CanUse = true;
            motor.enabled = true;
            control.enabled = true;
            animator.enabled = true;
            anim.enabled = true;
            Destroy(gameObject);
        }
    }

}
