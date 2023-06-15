using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeState : MonoBehaviour
{
    [SerializeField] ObjectScaling objectScaling;

    [SerializeField]
    public GameObject cube;   
    public int cubeState = 2;
    public Collider blockPressurePlate;



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
        if (collidedObject.gameObject.tag == "PressurePlate")
        {

            if (cubeState == 2)
            {
                cubeState = 1;
            }
            else
            {
                cubeState = 2;

            }
        }
    }

}
