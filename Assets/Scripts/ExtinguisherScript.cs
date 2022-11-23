using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherScript : MonoBehaviour
{
    public GameObject extinguisherParticleSystem;
    // public float fadeOutTime =5f;

    void Start()
    {
        extinguisherParticleSystem.SetActive(false);
    }

    void Update()
    {
        //used to activate fire extinguisher object

        if(Input.GetMouseButton(0)){
            extinguisherParticleSystem.SetActive(true);
        }else{
            // StartCoroutine(waiter());

           extinguisherParticleSystem.SetActive(false);

            // todo fadeout the extinguisher particles
        }
    }


    //checks if object is on fire, then extinguishes it after 5 seconds

}
