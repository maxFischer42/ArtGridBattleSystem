using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattle : MonoBehaviour {

    public GameObject lightHeal;
    public GameObject swordBash;

    public void UseArt(string artName)
    {
        switch(artName)
        {
            case "Light Heal":
                LightHeal();
                break;
            case "Sword Bash":
                SwordBash();
                break;
        }
    }

	public void LightHeal()
    {
        Instantiate(lightHeal);
    }

    public void SwordBash()
    {
        Instantiate(swordBash);
    }

}
