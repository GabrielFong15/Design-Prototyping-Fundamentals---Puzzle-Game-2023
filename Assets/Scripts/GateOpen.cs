using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    public GameObject[] Gate;
    public GameObject handScanner;
    public bool isNormalScanner;
    public bool isSmallScanner;
    private bool isGateOpen = true;
    private bool playerIsOn = false;
    [SerializeField] PlayerScaling PlayerScaling;
    public Material scannerOffMat;
    public Material scannerOnMat;


    void Update()
    {   // Check if the player has accessed to enable/disable gates
        if (playerIsOn)
          if(PlayerScaling.playerState == 2 && isNormalScanner || PlayerScaling.playerState == 1 && isSmallScanner) // Grab player state from a different script and check.
              if (Input.GetKeyDown(KeyCode.E))
                ToggleGate();
    }

    private void ToggleGate() 
    {
        isGateOpen = !isGateOpen;

        // For all gates in the array, turn off/on the gates.
        for (int i = 0; i < Gate.Length; i++)
        {
            if (isGateOpen == true)
            {
                Gate[i].SetActive(false);
                handScanner.GetComponent<Renderer>().material = scannerOnMat;
            }
            else
            {
                Gate[i].SetActive(true);
                handScanner.GetComponent<Renderer>().material = scannerOffMat;
            }
        }
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            playerIsOn = true;
        Debug.Log("entered");

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            playerIsOn = false;
        Debug.Log("exit");

    }

}
