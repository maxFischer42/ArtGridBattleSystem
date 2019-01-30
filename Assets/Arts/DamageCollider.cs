using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour {

    public float damage;

    private void OnTriggerEnter(Collider other)
    {

        if(other.GetComponent<EnemyHP>())
        {
            other.GetComponent<EnemyHP>().currentHP -= (damage / other.GetComponent<EnemyHP>().maxHP) * PlayerPrefs.GetFloat("DMGBuff");
            PlayerPrefs.SetFloat("DMGBuff", 1);
            Destroy(gameObject);
        }

        else if (other.GetComponent<PlayerStats>())
        {
            other.GetComponent<PlayerStats>().currentHealth -= (damage / other.GetComponent<PlayerStats>().maxHP);
            Destroy(gameObject);
        }

    }

    
}
