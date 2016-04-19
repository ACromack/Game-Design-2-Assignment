using UnityEngine;
using System.Collections;

public class EndDoorScript : MonoBehaviour {

	private bool isDoorOpen = false;
	
	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here
	
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () 
	{
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = sprite1; // set the sprite to sprite1
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (isDoorOpen == true)
		{
			Application.LoadLevel("Level2");
		}
		else
		{
			spriteRenderer.sprite = sprite1;
		}
	}
	
	
	public void changeDoorState()
	{
		isDoorOpen = true;
		
		if(isDoorOpen == true)
		{
			spriteRenderer.sprite = sprite2;
		}
		else
		{
			spriteRenderer.sprite = sprite1;
		}
		
		/*
		if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = sprite2;
			
		}
		else
		{
			spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
		}
		*/
	}
}
