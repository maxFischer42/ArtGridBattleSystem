using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Transform[] moveLocations;
    public float moveSpeed;
    private Rigidbody rigid;
    private Transform currentTarget;
    public Vector2 timeRange;
    private float timer;
    private float timerGoal;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        InitiateTarget();
        MoveToLocation(currentTarget.position);
    }

    public void InitiateTarget()
    {
        currentTarget = moveLocations[Random.Range(0, moveLocations.Length)];
        timer = 0;
        timerGoal = Random.Range(timeRange.x,timeRange.y);
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if (!(timerGoal <= timer))
        {
            MoveToLocation(currentTarget.position);
        }
        else
        {
            currentTarget = moveLocations[Random.Range(0, moveLocations.Length)];
            timer = 0;
        }
    }


    public void MoveToLocation(Vector3 location)
    {
        Vector3 direction = location - transform.position;
        direction.Normalize();
        rigid.velocity = direction * moveSpeed;
    }

}
