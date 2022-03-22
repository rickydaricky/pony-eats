using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deathCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    void OnCollisionEnter(Collision newCollision) {
        if (newCollision.gameObject.tag == "Pony")
        {
            if (deathCanvas)
                deathCanvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Destroy(gameObject);
        }
    }

}
