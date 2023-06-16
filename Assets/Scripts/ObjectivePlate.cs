using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePlate : MonoBehaviour
{
    public GameObject objectivePressurePlate;
    public Collider plateCollider;
    public int objectivePlateState;
    [SerializeField] CubeState CubeState;
    public bool objectivePlateActive;

    // Start is called before the first frame update
    void Start()
    {
        objectivePlateActive = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Object") 
        {
            if (CubeState.cubeState == objectivePlateState)
            {
                objectivePlateActive = true;
            }
            else
                objectivePlateActive = false;
        }
    }
}
