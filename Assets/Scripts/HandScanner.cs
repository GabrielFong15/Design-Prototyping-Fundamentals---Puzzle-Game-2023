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
    public int playerState;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        playerState = playerScaling.playerState;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Gate.SetActive(false);
        }

    }

    private void OnTriggerStay(Collider other)
    {
       BoxCollider bc = other.GetComponent<BoxCollider>();
       if(other.gameObject.tag == "Player")
        {
            if (playerScaling.playerState == 2 && isNormalScanner == true)
            {
                bc.isTrigger = true;
            }
            else
                bc.isTrigger = false;

            if (playerScaling.playerState == 1 && isSmallScanner == true)
            {
                bc.isTrigger = true;
            }
            else
                bc.isTrigger = false;
        }
    }

}
