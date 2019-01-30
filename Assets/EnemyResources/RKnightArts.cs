using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RKnightArts : EnemyArts {

    public float distanceToAttack;

	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (PlayerInRange() && !attacking)
        {
            int rand = Random.Range(0, arts.Length);
            Atk(rand);
            
        }
	}

    bool PlayerInRange()
    {
        bool value = false;
        Vector3 playerPos = GameObject.Find("Controller").transform.position;
        RaycastHit hit;
        Vector3 direction = playerPos - transform.GetChild(0).transform.position;
        direction.Normalize();
        //GetComponent<LineRenderer>().SetPosition(0, transform.GetChild(0).transform.position);
        //GetComponent<LineRenderer>().SetPosition(1, transform.GetChild(0).transform.position + (direction * distanceToAttack));
        if (Physics.Raycast(transform.position, direction, out hit, distanceToAttack))
        {
            
            if (hit.collider.gameObject.name == "Controller")
            {
                value = true;
            }
        }
        return value;
    }


    void Atk(int var)
    {
        if(!disable[var])
        {
            disable[var] = true;
            StartCoroutine(UseArt(var,animations[var]));
            Debug.Log("Attack!");
        }
    }
}
