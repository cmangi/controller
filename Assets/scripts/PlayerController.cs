using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// how fast the player can move
	public int travelSpeed = 100;
	public int turnSpeed = 100;
		
		
		
	// Update is called once per frame
	void Update () 
	{
		ProcessForwardMove();
		ProcessTurnMove();
		
		
		
	}
	
	//
	void ProcessForwardMove()
	{
		//get keyboard input for forward movement key
		if (Input.GetKey (KeyCode.W))
		{
			//if yes, move forward for the amount of time it is held.
			//Z axis
			transform.Translate (0,0,travelSpeed * Time.deltaTime);	
		}
		
		//get keyboard input for backward movement key
		if (Input.GetKey (KeyCode.S))
		{
			//if yes, move backward for the amount of time it is held.
			//Z axis
			transform.Translate (0,0,-travelSpeed * Time.deltaTime);
			
		}
	}
	
	void ProcessTurnMove()
	{
		//get keyboard input for left turn movement key
		if (Input.GetKey (KeyCode.D))
		{
			//if yes, turn left for the amount of time it is held.
			//Z axis
			transform.Rotate (0,turnSpeed * Time.deltaTime, 0);	
		}
		
		//get keyboard input for right turn movement key
		if (Input.GetKey (KeyCode.A))
		{
			//if yes, turn right for the amount of time it is held.
			//Z axis
			transform.Rotate (0,-turnSpeed * Time.deltaTime, 0);
			
		}
	}
	
	
}
