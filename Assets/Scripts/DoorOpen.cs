using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    [SerializeField] ObjectivePlate[] objectivePlate;
    private bool[] pressurePlateChecker;
    public bool doorStateOn = false;

    
    void Start()
    {

    }

    void Update()
    {

        /*for (int i = 0; i < pressurePlateChecker.Length; i++) 
        {
            if (pressurePlateChecker[i] == false)
            {
                doorStateOn = true;
                break;
            }
            doorStateOn = false;
        }
        Door.SetActive(doorStateOn);*/

        for(int i = 0; i < objectivePlate.Length; i++)
        {
            if (objectivePlate[i] == false)
            {
                doorStateOn = false;
                break;
            }
            doorStateOn = true;
        }

        if (doorStateOn == true)
            Door.SetActive(false);
        else
            Door.SetActive(true);

    }

}
