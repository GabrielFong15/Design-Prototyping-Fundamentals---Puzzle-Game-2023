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
    private bool[] pressurePlateChecker;
    [SerializeField] ObjectivePlate objectivePlate;
    public bool doorState;
    
    // Start is called before the first frame update
    void Start()
    {
        doorState = false;
        for (int i = 0; i < pressurePlate.Length; i++) {
            for (int j = 0; j < 1; j++) {
                pressurePlateChecker[j] = objectivePlate.objectivePlateActive;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < pressurePlateChecker.Length; i++) 
        {
            if (pressurePlateChecker[i] == false)
            {
                doorState = false;
                break;
            }
            doorState = true;
        }
       
        Door.SetActive(doorState);
    }
}
