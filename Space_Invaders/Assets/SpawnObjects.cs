using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour 
{

    public GameObject spawnObject;
    public float spawnAreaWidth;
    public float spawnAreaHeight;
    public int numberOfEnemiesX;
    public int numberOfEnemiesY;

    private int xOffset;
    private int yOffset;

	// Use this for initialization
	void Start () 
    {
        xOffset = 4;
        yOffset = 4;
        
        
        
        for (int i = 0; i < numberOfEnemiesX; i++)
        {                        
            for (int j = 0; j < numberOfEnemiesY; j++)
            {
                Vector3 spawnPosition = new Vector3(transform.position.x + (i * xOffset), transform.position.y - (j * yOffset), 0.0f);
                Instantiate(spawnObject, spawnPosition, transform.rotation);
            }

        }
	}
	
	
}
