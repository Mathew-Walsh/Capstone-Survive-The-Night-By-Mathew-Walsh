using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour {

    public GameObject barrelExplosion;

    public GameObject barrel;
    public GameObject damageCollider;

    AudioSource audioSource;
    public AudioClip barrelExplosionSound;


    private bool barrelActive = false;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
        {   
            // Play Explosion Sound
            audioSource.PlayOneShot(barrelExplosionSound, 1f);
            
            // Instantiate particle effect
            Instantiate(barrelExplosion, transform.position, Quaternion.Euler(-90, 0, 0));

            // Activate damage mechanism
            damageCollider.SetActive(true);

            // Deactivate object
            Destroy(barrel, 1.8f);
        }    
    }


}
