using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScaling : MonoBehaviour
{
    public GameObject PlayerPressurePlate;
    public int playerState = 2;
    public FPSMovement FPSMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    void OnTriggerEnter(Collider collidedPlayer)
    {
        if (collidedPlayer.gameObject.tag == "Player")
        {
            if (playerState == 2)
            {
                collidedPlayer.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
                FPSMovement FPSMove = collidedPlayer.GetComponent < FPSMovement>();
                FPSMove.m_jumpHeight = 0.4f;
                playerState = 1;
               
            }
            else
            {
                collidedPlayer.transform.localScale = new Vector3(1f, 1f, 1f);
                FPSMovement FPSMove = collidedPlayer.GetComponent<FPSMovement>();
                FPSMove.m_jumpHeight = 1.4f;
                playerState = 2;
            }
        }
       


    }

}
