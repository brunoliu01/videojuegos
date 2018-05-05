using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour {
	public Rigidbody2D ballBody;
	private float forceX = 10.0f;
	private float forceY = 15.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector2 forceLeft = new Vector2 (-forceX,0);
			ballBody.AddForce(forceLeft);
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			Vector2 forceRight = new Vector2 (forceX, 0);
			ballBody.AddForce (forceRight);
		}
		if (Input.GetKey (KeyCode.UpArrow))
		{
			Vector2 forceUp = new Vector2 (0, forceY);
			ballBody.AddForce (forceUp);
		}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			Vector2 forceDown = new Vector2 (0,-forceY);
			ballBody.AddForce (forceDown);
		}
	}
		 
}
