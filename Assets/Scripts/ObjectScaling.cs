using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class ObjectScaling : MonoBehaviour
{
    public GameObject ObjectPressurePlate;
    private int objectState = 2;
    public Collider Collider;
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
                OnTriggerStay(Collider);
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

void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "PressurePlate")
        {
            BoxCollider boxCollider = collider.GetComponent<BoxCollider>();
            BoxCollider bc = boxCollider;

            if (bc.isTrigger == true)
                collider.enabled = !collider.enabled;
        }
    }

    }

    

}

