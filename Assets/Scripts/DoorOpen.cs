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
    {
        pressurePlateChecker = new bool[pressurePlates.Length];

        for(int i = 0; i < pressurePlateChecker.Length; i++) {
            pressurePlateChecker[i] = false;
        }
    }

    void Update()
    {

        for(int i = 0; i < pressurePlates.Length; i++)
        {
            for(int j = 0; j < pressurePlateChecker.Length; j++)
            {
                ObjectivePlate objectPlate = pressurePlates[i].GetComponent<ObjectivePlate>();
                pressurePlateChecker[j] = objectPlate.plateIsActive;
                i++;
            }
        }

        for (int i = 0; i < pressurePlateChecker.Length; i++)
        {
            if (pressurePlateChecker[i] == false)
            {
                doorStateOn = false;
                ToggleDoor();
                break;
            }
            doorStateOn = true;
        }
        ToggleDoor();
    }

    private void ToggleDoor()
    {
     if (doorStateOn == true)
         Door.SetActive(false);
     else
         Door.SetActive(true);
    }

}
