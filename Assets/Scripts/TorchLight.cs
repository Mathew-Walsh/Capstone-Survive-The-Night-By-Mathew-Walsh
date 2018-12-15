using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLight : MonoBehaviour {

    // Torch Materials
    //public Renderer torchRenderer;
    //public Material activeMaterial;
    //public Material inactiveMaterial;

    // Torch Audio when hitting floor
    AudioSource audioSource;

    // TorchLight Game object
    public GameObject torchLight;
    public GameObject lightCone;

	// Use this for initialization
	void Start ()
        {

        //torchRenderer = GetComponent<Renderer>();
        //torchRenderer.material = inactiveMaterial;
        audioSource = GetComponent<AudioSource>();
        
        }

    public void ToggleTorchLight(bool lightOn)
    {
        torchLight.SetActive(lightOn);
        lightCone.SetActive(lightOn);
        audioSource.Play();

    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1.5)
            audioSource.Play();
    }
    */
}
