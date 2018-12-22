using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float walkSpeed;
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    public void Walk(Vector3 direction)
    {
        rigidbody.velocity = direction * walkSpeed;
    }

    public void checkMove(Vector3 direction)
    {
        if(direction.x != 0 && direction.y != 0)
        {

        }
        else
        {
            Walk(direction);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            SceneManager.LoadScene("LevelLoader");
        }
    }


}
