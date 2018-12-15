using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twig : MonoBehaviour {

    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            audioSource.Play();
        }
        else
        {
            return;
        }
    }

}
