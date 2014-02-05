using UnityEngine;
using System.Collections;

public class bulletMove : MonoBehaviour 
{
	public float speed;

	// Use this for initialization
	void Start () 
	{
		Vector3 newVel = Vector3.zero;
		
		newVel.y = speed;
		
		rigidbody.velocity = newVel;
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		Vector3 newPos = transform.position;
		newPos.y +=  speed * Time.deltaTime;
		transform.position = newPos;
		*/
	}
}
