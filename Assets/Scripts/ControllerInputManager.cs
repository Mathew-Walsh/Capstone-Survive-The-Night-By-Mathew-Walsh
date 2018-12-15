using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerInputManager : MonoBehaviour {

    public SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;

    private bool lightOn = false;
    //public TorchLight torchLight;

    public float throwForce = 2f;


    // Use this for initialization
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }


    // Update is called once per frame
    void Update () {

        device = SteamVR_Controller.Input((int)trackedObj.index);


    }






    void OnTriggerStay(Collider col)
    {
        /*
        // Torch Mech
        if (col.gameObject.tag == "Torch")
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
            {
                GrabObject(col);
                Debug.Log("Grabbing Torch");
            }
            else if (device.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
            {
                ThrowObject(col);
                Debug.Log("Releasing Torch");
            }
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                lightOn = !lightOn;
                torchLight.ToggleTorchLight(lightOn);
            }
            
        }
        */

        
        // Door Mech
        if (col.gameObject.tag == "Door")
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                SteamVR_LoadLevel.Begin("MainScene");
                //GrabDoor(col);
                //Debug.Log("Grabbing Door");
            }
            /*else if (device.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
            {
                ReleaseObject(col);
                //Debug.Log("Releasing Door");
            }
            */
        }
        

        /*
        // Hand Gun Mech
        if (col.gameObject.tag == "HandGun")
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
            {
                GrabObject(col);
                Debug.Log("Grabbing Hand Gun");
            }
            else if (device.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
            {
                ThrowObject(col);
                Debug.Log("Releasing Hand Gun");
            }
        }
        */
        
        
        //Throwable Mech
        if (col.gameObject.tag == "Throwable")
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
            {
                GrabObject(col);
                //Debug.Log("Grabbing Throwable Object");
            }
            else if (device.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
            {
                ThrowObject(col);
                //Debug.Log("Releasing Throwable Object");
            }
        }
        
        /*
        // Grenade Pin Mech
        if (col.gameObject.tag == "GrenadePin")
        {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                GrabObject(col);
                //Debug.Log("Grabbing Grenade Pin");
            }
            else if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                ReleaseObject(col);
                //Debug.Log("Releasing Grenade Pin");
            }
        }
        */
    }
        
    void GrabObject(Collider coli)
    {
        coli.transform.SetParent(gameObject.transform);
        coli.GetComponent<Rigidbody>().isKinematic = true;
        device.TriggerHapticPulse(3000);
    }

    void ThrowObject(Collider coli)
    {
        coli.transform.SetParent(null);
        Rigidbody rigidBody = coli.GetComponent<Rigidbody>();
        rigidBody.isKinematic = false;
        rigidBody.velocity = device.velocity * throwForce;
        rigidBody.angularVelocity = device.angularVelocity;
    }

    void ReleaseObject(Collider coli)
    {
        coli.transform.SetParent(null);
    }

    /*
    void GrabDoor(Collider coli)
    {
        coli.GetComponent<Rigidbody>().isKinematic = true;
        device.TriggerHapticPulse(3000);
    }
    */
}
