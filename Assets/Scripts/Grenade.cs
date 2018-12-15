using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Grenade : MonoBehaviour {

    public GameObject grenadeExplosion;

    public GameObject damageCollider;
    public GameObject grenade;
    public GameObject grenadePin;


    public AudioSource audioSource;
    public AudioClip hitObject;
    public AudioClip explosion;
    public AudioClip pinPulled;

    private bool grenadeActive = false;

	// Use this for initialization
	void Start ()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1.5f)
        {
            audioSource.clip = hitObject;
            audioSource.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GrenadePin")
        {
            audioSource.clip = pinPulled;
            audioSource.Play();
            grenadeActive = !grenadeActive;
            damageCollider.SetActive(true);
            grenadePin.SetActive(false);
            StartCoroutine(DetonateGrenade());
        }
    }

    IEnumerator DetonateGrenade()
    {
        yield return new WaitForSeconds(5f);

        audioSource.clip = explosion;
        audioSource.Play();

        // Instantiates the bottle smash particle on location
        Instantiate(grenadeExplosion, transform.position, Quaternion.Euler(-90, 0, 0));

        // Sets the status
        grenade.SetActive(false);
        //grenadePin.SetActive(false);



    }
}
