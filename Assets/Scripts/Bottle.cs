using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {

    public GameObject bottleSmash;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.relativeVelocity.magnitude > 1.5)
        {
            // Plays smashing glass Sound on impact
            audioSource.Play();

            // Instantiates the bottle smash particle on location
            Instantiate(bottleSmash, transform.position, Quaternion.Euler(-90, 0, 0));

            // Sets the bottle status
            //gameObject.SetActive(false);

            Destroy(gameObject, 0.4f);

        }

    }
}
