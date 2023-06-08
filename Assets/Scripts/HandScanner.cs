using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class HandScanner : MonoBehaviour
{
    public bool isNormalScanner;
    public bool isSmallScanner;
    public PlayerScaling playerState;
    public GameObject Gate;

    public PlayerScaling PlayerState { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        PlayerScaling PlayerState = GetComponent<PlayerScaling>();
        if (PlayerState.playerState == 2 && isNormalScanner == true) 
        {
            Gate.SetActive(false);
        }

            
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
