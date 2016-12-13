﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour 
{
	public bool hide = false;
	public Sprite hidden;

	private SpriteRenderer spriteRenderer;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void OnTriggerStay(Collider other)
	{

		Debug.Log ("PATATE");

		if (other.gameObject.tag == "Table" && Input.GetKeyDown(KeyCode.LeftControl)) 
		{
			Debug.Log ("HIDE");
			spriteRenderer.sprite = hidden;

			if (!hide) 
			{
				hide = true;
			} 
			else 
			{
				hide = false;
			}
		}
	}
	
}
