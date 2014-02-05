using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour 
{
	public GameObject[] gibs;
	public float explosionForce;
	public float spawnRadius = 1;
	
	void OnTriggerEnter(Collider other)
	{

        if (gameObject.tag == "Enemy" && other.gameObject.tag == "Player")
        {
            foreach (var gib in gibs)
            {
                GameObject gibInstance = (GameObject)Instantiate(gib, other.gameObject.transform.position + Random.insideUnitSphere * spawnRadius, other.gameObject.transform.rotation);
                gibInstance.rigidbody.AddExplosionForce(explosionForce, other.gameObject.transform.position, spawnRadius);
            }
            Destroy(other.gameObject);
        }
        else
        {
            foreach (var gib in gibs)
            {
                GameObject gibInstance = (GameObject)Instantiate(gib, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation);
                gibInstance.rigidbody.AddExplosionForce(explosionForce, transform.position, spawnRadius);
            }
            Destroy(gameObject);	
        }
        
        
        
	}
}
