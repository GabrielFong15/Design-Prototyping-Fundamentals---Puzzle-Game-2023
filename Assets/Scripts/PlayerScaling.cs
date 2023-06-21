using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScaling : MonoBehaviour
{
    public GameObject playerPressurePlate;
    public int playerState = 2;
    public FPSMovement FPSMovement;



    void OnTriggerEnter(Collider collidedPlayer)
    {
        if (collidedPlayer.gameObject.tag == "Player")
        {
            if (playerState == 2)
            {
                collidedPlayer.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
                FPSMovement FPSMove = collidedPlayer.GetComponent<FPSMovement>();
                FPSMove.m_jumpHeight = 0.4f;
                FPSMove.m_movementSpeed = 3f;
                FPSMove.m_gravity = -15f;
                playerState = 1;

            }
            else
            {
                collidedPlayer.transform.localScale = new Vector3(1f, 1f, 1f);
                FPSMovement FPSMove = collidedPlayer.GetComponent<FPSMovement>();
                FPSMove.m_jumpHeight = 1.1f;
                FPSMove.m_movementSpeed = 6f;
                FPSMove.m_gravity = -35f;
                playerState = 2;
               
            }
        }
        
    }
}
