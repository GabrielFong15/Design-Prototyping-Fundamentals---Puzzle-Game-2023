using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    public bool[] pressurePlate;
    [SerializeField]  ObjectivePlate objectivePlate;
    public bool doorState;
    
    // Start is called before the first frame update
    void Start()
    {
        doorState = false;

        for(int i = 0; i < pressurePlate.Length; i++)
        {
            pressurePlate[i] = objectivePlate.objectivePlateActive;
        }
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < pressurePlate.Length; i++) 
        {
            if (pressurePlate[i] == false)
            {
                doorState = false;
                break;
            }
            doorState = true;
        }

        if (objectivePlate.objectivePlateActive == true) 
        { 
            doorState = true;
        }

        if(doorState == true)
            gameObject.SetActive(false);
        if(doorState == false)
            gameObject.SetActive(true);

    }
}
