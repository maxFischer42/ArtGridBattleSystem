using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour {

    public EnemyInfo myEnemy;
    public Text NameBox;
    public Scrollbar healthBar;
    public float maxHP;
    public float currentHP;

    private void Start()
    {
        maxHP = myEnemy.HP;
        currentHP = maxHP;
    }

    public void FixedUpdate()
    {
        healthBar.size = currentHP / maxHP;
    }

}
