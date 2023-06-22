using Palmmedia.ReportGenerator.Core.Parser.Filtering;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePlate : MonoBehaviour
{
    public GameObject objectivePressurePlate;
    public GameObject objectivePlateVisual;
    public int objectivePlateState;
    [SerializeField] CubeState CubeState;
    public bool objectivePlateActive = false;
    public bool plateIsActive = false;
    public GameObject Door;
    public Material emmisiveMat;
    public Material defaultMat;




    void Update()
    {
        // Check if the block fits the requirement of the objective pressure plate
        if (objectivePlateActive)
            if (CubeState.cubeState == objectivePlateState)
            {
                plateIsActive = true;
                objectivePlateVisual.GetComponent<Renderer>().material = emmisiveMat;
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
            plateIsActive = false;
            Door.SetActive(true);
            objectivePlateVisual.GetComponent<Renderer>().material = defaultMat;
            Debug.Log("plate is de-active");
        }
            
    }


}
