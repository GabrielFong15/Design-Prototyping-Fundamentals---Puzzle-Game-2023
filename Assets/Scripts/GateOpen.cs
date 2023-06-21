using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    public GameObject Gate;
    public bool isNormalScanner;
    public bool isSmallScanner;
    [SerializeField] PlayerScaling PlayerScaling;
    private bool isGateOpen = true;
    private bool playerIsOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsOn)
          if(PlayerScaling.playerState == 2 && isNormalScanner || PlayerScaling.playerState == 1 && isSmallScanner)
              if (Input.GetKeyDown(KeyCode.E))
                ToggleGate();
    }

    private void ToggleGate() 
    {

            if (isGateOpen == true)
                isGateOpen = false;
            else
                isGateOpen = true;
            //---------------------------

            if (isGateOpen == true)
                Gate.SetActive(false);
            else
                Gate.SetActive(true);
        
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
