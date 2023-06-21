using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePlate : MonoBehaviour
{
    public GameObject objectivePressurePlate;
    public int objectivePlateState;
    [SerializeField] CubeState CubeState;
    public bool objectivePlateActive = false;
    public bool plateIsActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (objectivePlateActive)
            if (CubeState.cubeState == objectivePlateState)
            {
                plateIsActive = true;
            }
             else
                plateIsActive = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Object")
        {
            objectivePlateActive = true;
            Debug.Log("plate is active");
        }
            
            
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Object")
        {
            objectivePlateActive = false;
            Debug.Log("plate is de-active");
        }
            
    }


}
