using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class ObjectScaling : MonoBehaviour
{
    public Collider ObjectPressurePlate;
    private int objectState = 2;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.gameObject.tag == "Object")
        {
            if (objectState == 2)
            {
                collidedObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                Rigidbody rb = collidedObject.GetComponent<Rigidbody>();
                rb.mass = 0.5f;
                rb.drag = 0.8f;
                objectState = 1;
            }
            else
            {
                collidedObject.transform.localScale = new Vector3(1f, 1f, 1f);
                Rigidbody rb = collidedObject.GetComponent<Rigidbody>();
                rb.mass = 1f;
                rb.drag = 1f;
                objectState = 2;
            }
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PressurePlate")
        {
            BoxCollider boxCollider = other.GetComponent<BoxCollider>();
            if (boxCollider.isTrigger == true)
                boxCollider.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PressurePlate")
        {
            BoxCollider boxCollider = other.GetComponent<BoxCollider>();
            if (boxCollider.isTrigger == false)
                boxCollider.enabled = true;
        }
    }
}



