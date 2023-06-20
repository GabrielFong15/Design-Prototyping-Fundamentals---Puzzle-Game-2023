using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    public GameObject Gate;
    public bool isNormalScanner;
    public bool isSmallScanner;
    [SerializeField] PlayerState PlayerState;
    private bool isGateOpen = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerState.playerState == 2 && isNormalScanner || PlayerState.playerState == 1 && isSmallScanner)
        if (Input.GetKeyDown(KeyCode.E))
            ToggleGate();
    }

    private void ToggleGate() 
    { 
        if(isGateOpen == true)
            isGateOpen = false;
        else
            isGateOpen = true;

        if (isGateOpen == true)
            Gate.SetActive(false);
        else
            Gate.SetActive(true);
    }

}
