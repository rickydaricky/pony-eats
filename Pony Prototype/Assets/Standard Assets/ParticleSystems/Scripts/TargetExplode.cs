using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TargetExplode : MonoBehaviour
{

	// explosion when hit
	public GameObject explosionPrefab;

	void Start ()
    {
		//myScript = this.gameObject.GetComponent<Escape>();
	}




	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			if (explosionPrefab) {
				// Instantiate an explosion effect at the gameObjects position and rotation
				Instantiate (explosionPrefab, transform.position, transform.rotation);
			}
			// destroy the projectile
			Destroy (newCollision.gameObject);

			// destroy self
			//myScript.enabled = false;

			Destroy(gameObject);

		}
	}
}
