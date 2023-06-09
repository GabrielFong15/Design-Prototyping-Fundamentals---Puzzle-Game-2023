using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeState : MonoBehaviour
{
    public ObjectScaling blockState;

    [SerializeField]
    public int cubeState;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        blockState = GetComponent<ObjectScaling>();
        
    }

}
