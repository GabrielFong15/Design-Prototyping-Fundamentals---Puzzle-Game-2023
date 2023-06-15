using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class HandScanner : MonoBehaviour
{
    public bool isNormalScanner;
    public bool isSmallScanner;
    public PlayerScaling playerScaling;
    public GameObject Gate;
    private bool gateState;
    private bool allowInteract;

    // Start is called before the first frame update
    void Start()
    {
        gateState = false; //closed
        allowInteract = false;
    }

    // Update is called once per frame

    void Update()
    {
       PlayerScaling PlayerState = GetComponent<PlayerScaling>();
        if (PlayerState.playerState == 2 && isNormalScanner == true || PlayerState.playerState == 2 && isSmallScanner == true) 
        {
            allowInteract = true;
        }
        else
        {
            allowInteract = false;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (allowInteract == true)
        {
            if (other.gameObject.tag == "Player")
            {
                //if its closed, then open
                if (Input.GetKeyDown(KeyCode.E) && gateState == false)
                {
                    Gate.SetActive(false);
                    gateState = true;
                }
                //if its open, then close
                if (Input.GetKeyDown(KeyCode.E) && gateState == true)
                {
                    Gate.SetActive(false);
                    gateState = false;

                }
            }
        }
    }

}
