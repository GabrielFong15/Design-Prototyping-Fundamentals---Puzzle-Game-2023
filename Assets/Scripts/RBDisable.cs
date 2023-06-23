using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBDisable : MonoBehaviour
{
    public Collider Player;

    //Prevent a block from moving when in contact of the player
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
