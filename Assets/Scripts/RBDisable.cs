using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBDisable : MonoBehaviour
{
    public Collider Player;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Object" || other.gameObject.tag == "ObjectProp")
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Object" || other.gameObject.tag == "ObjectProp")
            other.GetComponent<Rigidbody>().isKinematic = false;
    }
}
