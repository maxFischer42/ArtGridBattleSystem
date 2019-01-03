using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattle : MonoBehaviour {

    public GameObject lightHeal;

    public void UseArt(string artName)
    {
        switch(artName)
        {
            case "Light Heal":
                LightHeal();
                break;
        }
    }

	public void LightHeal()
    {
        Instantiate(lightHeal);
    }


}
