using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeState : MonoBehaviour
{
    [SerializeField] ObjectScaling objectScaling;

    [SerializeField]
    public GameObject cube;   
    public int cubeState;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cubeState = objectScaling.blockState;
    }

}
