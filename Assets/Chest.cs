using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

    public GameObject toolTip;
    public GameObject ItemPrompt;
    public RuntimeAnimatorController Open;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            toolTip.SetActive(true);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetButtonDown("Submit"))
        {
            GetComponent<Animator>().runtimeAnimatorController = Open;
            Destroy(toolTip);
            StartCoroutine(Delay());
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            toolTip.SetActive(false);
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Instantiate(ItemPrompt);
        this.enabled = false;
    }
}
