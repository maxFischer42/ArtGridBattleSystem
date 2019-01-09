using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RKnightArts : EnemyArts {

    public Vector3 distanceToAttack;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(PlayerInRange())
        {
            SpearBreak();
        }
	}

    bool PlayerInRange()
    {
        bool value = false;
        Vector3 playerPos = GameObject.Find("Controller").transform.position;
        Vector3 myPos = transform.position;
        Vector3 distance = myPos - playerPos;
        distance.Normalize();
        distance = distance.normalized;
        Debug.Log(distance);
        if(Mathf.Abs(distance.x) <= distanceToAttack.x && Mathf.Abs(distance.z) <= distanceToAttack.z)
        {
            Debug.Log("Close to player");
            value = true;
        }
        else
        {
            Debug.Log("Too far from player");
        }
        return value;
    }


    void SpearBreak()
    {
        if(!disable[0])
        {
            Debug.Log("Spear Break!");
            UseArt(0,animations[0]);
        }
    }
}
