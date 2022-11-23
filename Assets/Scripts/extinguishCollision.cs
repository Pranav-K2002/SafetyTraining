using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extinguishCollision : MonoBehaviour
{
    public string colliderName = "fireCollider";
    public float hitDistance = 10f;
    public float rateX=1;
    public float rateY=1;
    public float rateZ=1;

    private Vector3 fireSize=new Vector3(0.1f,0.1f,0.1f);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButton(0)){
                if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit, 100f)){
                    if(hit.collider.name == colliderName && hit.distance <= hitDistance)
                    {
                        Debug.Log("hit");
                        hit.transform.localScale -=fireSize;
                        // hit.transform.localScale.y -=rateY;
                        // hit.transform.localScale.z -=rateZ;
                        // Destroy(hit.transform.gameObject);
                    }
                }
            }
    }


}
