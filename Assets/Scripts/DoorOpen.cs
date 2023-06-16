using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    public GameObject[] pressurePlate;
    public bool[] pressurePlateChecker;
    [SerializeField] ObjectivePlate objectivePlate;
    public bool doorStateOn;
    private int length;
    
    void Start()
    {
        doorStateOn = false;
        length = pressurePlate.Length;

        for (int i = 0; i < pressurePlate.Length; i++)
        {
            for (int j = 0; j < 1; j++)
            {
                pressurePlateChecker[j] = objectivePlate.objectivePlateActive;
            }
        }

    }

    void Update()
    {
        for (int i = 0; i < pressurePlateChecker.Length; i++) 
        {
            if (pressurePlateChecker[i] == false)
            {
                doorStateOn = true;
                break;
            }
            doorStateOn = false;
        }
        Door.SetActive(doorStateOn);
    }
}
