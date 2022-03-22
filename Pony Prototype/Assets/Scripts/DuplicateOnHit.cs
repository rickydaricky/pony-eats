using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnCollisionEnter(Collision newCollision)
    {
        if (newCollision.gameObject.tag == "Projectile")
        {
            Destroy(newCollision.gameObject);
            GameObject newProjectile = Instantiate(gameObject, transform.position + transform.forward, transform.rotation) as GameObject;
        }
    }
}