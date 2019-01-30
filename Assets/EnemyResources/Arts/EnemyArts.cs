using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyArts : MonoBehaviour {

    [HideInInspector]
    public EnemyMovement enMov;
    public EArt[] arts;
    public Text warningText;
    public RuntimeAnimatorController[] animations;
    public RuntimeAnimatorController idle;
    public Animator animator;
    public float[] cooldowns, currentCooldown;
    public bool[] disable;
    public bool attacking;

	// Use this for initialization
	void Start ()
    {
        animator.runtimeAnimatorController = idle;
        enMov = GetComponent<EnemyMovement>();
        cooldowns = new float[arts.Length];
        currentCooldown = new float[arts.Length];
        disable = new bool[arts.Length];
        for(int i = 0; i < arts.Length; i++)
        {
            cooldowns[i] = arts[i].cooldown;
            disable[i] = false;
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
		for(int i = 0; i < disable.Length; i++)
        {
            if(disable[i] == true)
            {
                if(currentCooldown[i] >= cooldowns[i])
                {
                    currentCooldown[i] = 0;
                    disable[i] = false;
                    break;
                }
                currentCooldown[i]+=Time.deltaTime;
            }
        }
	}

    public IEnumerator UseArt(int _ID, RuntimeAnimatorController _animation)
    {
        attacking = true;
        enMov.enabled = false;
        GameObject warning = (GameObject)Instantiate(arts[_ID].warning, transform);
        Destroy(warning, arts[_ID].warningTime);
        Debug.Log("Attack Begin");
        warningText.text = arts[_ID].name;
        yield return new WaitForSeconds(arts[_ID].warningTime);
        Debug.Log("Change Animation");
        animator.runtimeAnimatorController = _animation;
        arts[_ID].UseArt(transform);
        Debug.Log("Use Art");
        yield return new WaitForSeconds(arts[_ID].animationTime);
        Debug.Log("End Art");
        animator.runtimeAnimatorController = idle;
        warningText.text = "No Current Action";
        enMov.enabled = true;
        attacking = false;
    }


}
