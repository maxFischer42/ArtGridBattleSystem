using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBattle : MonoBehaviour {

    public bool CanUse = true;

    //these can be replaced by arrays//
    public GameObject lightHeal;  
    public GameObject swordBash;
    public GameObject shadowEye;
    //

    //this too
    public Button lhButton;
    public Button sbButton;
    public Button seButton;
    //


    public void UseArt(string artName)
    {
        if (!CanUse)
            return;
        switch(artName)
        {
            case "Light Heal":
                LightHeal();
                break;
            case "Sword Bash":
                SwordBash();
                break;
            case "Shadow Eye":
                ShadowEye();
                break;
        }
    }

    //these can be turned into 1 function
	public void LightHeal()
    {
        Instantiate(lightHeal);
        lhButton.interactable = false;
        lhButton.GetComponent<Cooldown>().isUsed = true;
    }
    public void SwordBash()
    {
        Instantiate(swordBash);
        sbButton.interactable = false;
        sbButton.GetComponent<Cooldown>().isUsed = true;
    }
    public void ShadowEye()
    {
        Instantiate(shadowEye);
        seButton.interactable = false;
        seButton.GetComponent<Cooldown>().isUsed = true;
    }
    //
}
