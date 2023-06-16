using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class HandScanner : MonoBehaviour
{
    public bool isNormalScanner;
    public bool isSmallScanner;
    public PlayerState PlayerState;
    public GameObject Gate;
    public int playerState;
    public bool isInteract;
    // Start is called before the first frame update
    void Start()
    {
        isInteract = true;
    }

    // Update is called once per frame

    void Update()
    {
        playerState = PlayerState.playerState;

        if (gameObject.tag == ("Player"))
        {
            if (playerState == 2 && isNormalScanner == true)
                isInteract = true;
            else if (playerState == 1 && isSmallScanner == true)
                isInteract = true;
            else
                isInteract = false;
        }

        if(isInteract == true)
             if (Input.GetKeyDown(KeyCode.E))
        {
             Gate.SetActive(false);
        }
    }



}
