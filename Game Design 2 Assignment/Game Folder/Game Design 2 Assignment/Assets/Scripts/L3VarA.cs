using UnityEngine;
using System.Collections;

public class L3VarA : MonoBehaviour {

	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here

	public GameObject object1; //First 
	
	private SpriteRenderer spriteRenderer; 
	
	public orGateScript testScript;

	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = sprite1; // set the sprite to sprite1
	}

	void Update ()
	{
		
	}


	void OnTriggerEnter2D(Collider2D other) 
	{
		ChangeTheDamnSprite ();
		//testScript.ChangeAndGateSprite();
		testScript.ChangeVariableA();
	}


	void ChangeTheDamnSprite ()
	{
		if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = sprite2;
		}
		else
		{
			spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
		}
	}
}
