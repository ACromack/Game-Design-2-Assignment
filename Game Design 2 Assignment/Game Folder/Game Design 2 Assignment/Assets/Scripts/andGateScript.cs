using UnityEngine;
using System.Collections;

public class andGateScript : MonoBehaviour {

	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here
	
	public bool variableAValue = false;
	public bool variableBValue = false;

	private SpriteRenderer spriteRenderer; 
	
	
	public GameObject objectDoor; //First
	public GameObject outCable1;
	public GameObject outCable2;
	
	public ChangeSpriteScriptOut outCableScript;
	public ChangeSpriteScriptOut outCableScript2;
	public EndDoorScript testScript2;
	

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
			if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
				spriteRenderer.sprite = sprite1; // set the sprite to sprite1
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(variableAValue == true && variableBValue == true)
		{
			spriteRenderer.sprite = sprite2;
			outCableScript.ChangeTheDamnSprite();
			outCableScript2.ChangeTheDamnSprite();
			testScript2.changeDoorState();
		}
		else
		{
			spriteRenderer.sprite = sprite1;
		}
	}
	
	
	public void ChangeAndGateSprite ()
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
	
	// Public Void for changing A variable
	public void ChangeVariableA()
	{
		if(variableAValue == false)
		{
			variableAValue = true;
		}
		else
		{
			variableAValue = false;
			outCableScript.isWireOn = false;
			outCableScript2.isWireOn = false;
		}
		
	}
	
	// Public Void for changing B variable
	public void ChangeVariableB()
	{
		if(variableBValue == false)
		{
			variableBValue = true;
		}
		else
		{
			variableBValue = false;
			outCableScript.isWireOn = false;
			outCableScript2.isWireOn = false;
		}
		
	}
	
}
