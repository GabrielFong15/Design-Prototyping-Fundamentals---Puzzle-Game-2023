using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    public GameObject[] pressurePlates;
    [SerializeField] private bool[] pressurePlateChecker;
    public bool doorStateOn = false;

    
    void Start()
    {  // Populate a new array based of the length of pressurePlates array
        pressurePlateChecker = new bool[pressurePlates.Length];

        for(int i = 0; i < pressurePlateChecker.Length; i++) {
            pressurePlateChecker[i] = false;
        }
    }

    void Update()
    {   // Assigning bool values into the pressurePlateChecker from the pressurePlate array
        for(int i = 0; i < pressurePlates.Length; i++)
        {
            for(int j = 0; j < pressurePlateChecker.Length; j++)
            {
                // Grab bool values from ObjectivePlate script and assigning its values
                ObjectivePlate objectPlate = pressurePlates[i].GetComponent<ObjectivePlate>();
                pressurePlateChecker[j] = objectPlate.plateIsActive;
                i++;
            }
        }

        // Checks if all the array has true values
        for (int i = 0; i < pressurePlateChecker.Length; i++)
        {
            if (pressurePlateChecker[i] == false)  // If any point a pressure plate is not active, do not open door.
            {
                doorStateOn = false;
                ToggleDoor();
                break;
            }
            doorStateOn = true;
        }
        ToggleDoor();
    }

    // Enable/Disable the door
    private void ToggleDoor()
    {
     if (doorStateOn == true)
         Door.SetActive(false);
     else
         Door.SetActive(true);
    }

}
