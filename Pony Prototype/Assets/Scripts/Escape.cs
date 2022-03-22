using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour

{
    public float speed = 10.0f;
    public float maxDist = 10.0f;
    public Transform target;

    private AudioClip[] _audioClip;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        if (target == null)
        {
            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) < maxDist) {
            Vector3 dir = transform.position - target.position;
            transform.Translate(dir * speed * Time.deltaTime);
            _audioSource.Play();
        }
    }
}
