using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{

    public float speed;
    public float leftEdge;
    public float rightEdge;
    public float dropDistance;
    private int count;

    private int direction;

	// Use this for initialization
	void Start () 
    {
        direction = 1;
        count = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
        count++;
        
        Vector3 newPostion = transform.position;

        if (count % 60 == 0)
        {
            newPostion.x += speed * Time.deltaTime * direction;

            transform.position = newPostion;

            if (transform.position.x > rightEdge)
            {
                direction = -1;

                newPostion = transform.position;

                newPostion.y -= dropDistance;

                transform.position = newPostion;
            }
            else if (transform.position.x < leftEdge)
            {
                direction = 1;

                newPostion = transform.position;

                newPostion.y -= dropDistance;

                transform.position = newPostion;
            }
        }
	}
}
