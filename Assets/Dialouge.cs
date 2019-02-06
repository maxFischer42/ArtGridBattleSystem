using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialouge : MonoBehaviour {

    public DialougeObject[] Conversation;
    public DialougeObject currentObject;
    public Text textObject;
    private float typeSpeed = 0.1f;
    private string targetString;
    private int currentCharacter;
    public string currentString;
    private float timer;
    int current;

    private void Start()
    {
        ChangeDialouge(0);
    }

    // Update is called once per frame
    void Update ()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(targetString == currentString)
            {
                ChangeDialouge(current + 1);
            }
            else
            {
                currentString = targetString;
            }
        }
        textObject.text = currentString;
		if(targetString != currentString && timer >= (typeSpeed / Time.timeScale))
        {
            currentString = targetString.Substring(0,currentCharacter);
            currentCharacter++;
            timer = 0;
        }
        timer += Time.deltaTime;

    }

    void ChangeDialouge(int select)
    {
        currentObject = Conversation[select];
        textObject.color = currentObject.Color;
        textObject.lineSpacing = currentObject.LineSpacing;
        textObject.fontSize = currentObject.Size;
        targetString = currentObject.Dialouge;
        typeSpeed = currentObject.TypeSpeed;
        currentCharacter = 0;
    }
}
