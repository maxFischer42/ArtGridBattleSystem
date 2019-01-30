using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

    public float maxHP = 550;
    public float currentHealth;
    public Scrollbar healthBar;
    public Text currentHealthText;
    public Text maxHealthText;

	// Use this for initialization
	void Start ()
    {
        currentHealth = maxHP;
        currentHealthText.text = currentHealth.ToString();
        maxHealthText.text = maxHP.ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
        healthBar.size = currentHealth / maxHP;
        if(currentHealth <= 0)
        {
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
	}

    public void Heal(float variable)
    {
        currentHealth += variable;
        if (currentHealth > maxHP)
            currentHealth = maxHP;
    }
}
