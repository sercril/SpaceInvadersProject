using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour 
{
	public float speed = 1.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 newPos = transform.position;
		newPos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		transform.position = newPos;
	}
}
