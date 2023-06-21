using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeState : MonoBehaviour
{
    [SerializeField] ObjectScaling objectScaling;

    [SerializeField]
    public int cubeState = 2;


    void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.gameObject.tag == "BlockPressurePlate")
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
