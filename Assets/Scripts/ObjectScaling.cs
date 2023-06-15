using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class ObjectScaling : MonoBehaviour
{

    public Collider blockPressurePlate;
    [HideInInspector] public int blockState = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //When a block lands on a pressure plate, toggle its size
    void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.gameObject.tag == "Object")
        {

            if (blockState == 2)
            {
                collidedObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                Rigidbody rb = collidedObject.GetComponent<Rigidbody>();
                rb.mass = 5f;
                rb.drag = 1f;
                blockState = 1;
                

            }
            else
            {
                collidedObject.transform.localScale = new Vector3(1f, 1f, 1f);
                Rigidbody rb = collidedObject.GetComponent<Rigidbody>();
                rb.mass = 30f;
                rb.drag =1f;
                blockState = 2;

            }
        }
    }




}



