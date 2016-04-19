using UnityEngine;
using System.Collections;

public class ChangeSpriteScriptOut : MonoBehaviour {

	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here
	
	private SpriteRenderer spriteRenderer;
	
	public bool isWireOn = false;


	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = sprite1; // set the sprite to sprite1
	}
	
	// Update is called once per frame
	void Update () {
		if(isWireOn == false)
		{
			spriteRenderer.sprite = sprite1;
		}
	}
	
	
	public void ChangeTheDamnSprite ()
	{
		isWireOn = true;
		
		if(isWireOn == true)
		{
			spriteRenderer.sprite = sprite2;
		}
		else
		{
			spriteRenderer.sprite = sprite1;
		}
		
		
	}
	
}
