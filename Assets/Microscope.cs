﻿using UnityEngine;

public class Microscope : MonoBehaviour {
    [SerializeField]private SpriteRenderer _overSpriteRenderer;


    //TODO should be a child class

    private void OnMouseUpAsButton()
    {
        PlayerBecher playerBecher = MySceneManager.GetPlayerController().BecherHeld;


        MySceneManager.GetDialogueBox().SetDialogue("You are using the miscroscope congrats !");
        MySceneManager.GetDialogueBox().DialogueActivate();
    }




    private void OnMouseOver()
    {
        _overSpriteRenderer.enabled = true;
    }

    private void OnMouseExit()
    {
        _overSpriteRenderer.enabled = false;
    }


    void Start()
    {
        _overSpriteRenderer.enabled = false;

    }
}
