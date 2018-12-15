using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    private AudioSource audioSource;

    Animator anim;

    [SerializeField]
    private GameObject muzzleFlashPrefab;

    [SerializeField]
    private Transform muzzlePoint;


	// Use this for initialization
	void Start () {

        audioSource = GetComponent<AudioSource>();

        anim = GetComponent<Animator>();

    }
	
	public void FireGun()
    {
        audioSource.Play();

        var muzzleFlash = Instantiate(muzzleFlashPrefab, muzzlePoint.position, muzzlePoint.rotation);
        Destroy(muzzleFlash.gameObject, 0.5f);

    }
}
