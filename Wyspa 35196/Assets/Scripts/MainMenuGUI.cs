using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class MainMenuGUI : MonoBehaviour
{
    public AudioClip beep;
    public GUISkin menuSkin;
    public Rect menuArea;
    public Texture gameLogo;

    Rect playBtnRect;
    Rect instructionsBtnRect;
    Rect quitBtnRect;

    float buttonWidth = 200;
    float buttonHeight = 40;
    float space = 20;

    // Start is called before the first frame update
    void Start()
    {
        playBtnRect = new Rect(50, 250, buttonWidth, buttonHeight);
        instructionsBtnRect = new Rect(50, 250 + buttonHeight + space, buttonWidth, buttonHeight);
        quitBtnRect = new Rect(50, 250 + (buttonHeight + space) * 2, buttonWidth, buttonHeight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.skin = menuSkin;
        GUI.BeginGroup(menuArea);
        GUI.DrawTexture(new Rect(0, 0, 300, 211), gameLogo);
        if (GUI.Button(playBtnRect, "Play"))
        {
            Debug.Log("Naciœniêto start");
            GetComponent<AudioSource>().PlayOneShot(beep);
        }
        if (GUI.Button(instructionsBtnRect, "Instructions"))
        {
            Debug.Log("Naciœniêto ins");
            GetComponent<AudioSource>().PlayOneShot(beep);
        }
        if (GUI.Button(quitBtnRect, "Quit"))
        {
            Debug.Log("Naciœniêto quit");
            GetComponent<AudioSource>().PlayOneShot(beep);
        }
        GUI.EndGroup();
    }
}
