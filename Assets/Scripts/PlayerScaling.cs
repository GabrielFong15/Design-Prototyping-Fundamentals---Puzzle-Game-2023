using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScaling : MonoBehaviour
{
    public GameObject playerPressurePlate;
    public GameObject pickupPoint;
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
                FPSMove.m_jumpHeight = 0.54f;
                FPSMove.m_movementSpeed = 3f;
                FPSMove.m_gravity = -20f;
                playerState = 1;
                pickupPoint.transform.localPosition = new Vector3(0f, 0.65f, 3f);
            }
            else
            {
                collidedPlayer.transform.localScale = new Vector3(1f, 1f, 1f);
                FPSMovement FPSMove = collidedPlayer.GetComponent<FPSMovement>();
                FPSMove.m_jumpHeight = 1.1f;
                FPSMove.m_movementSpeed = 6f;
                FPSMove.m_gravity = -35f;
                pickupPoint.transform.localPosition = new Vector3(0f, 0.65f, 2f);
                playerState = 2;
               
            }
        }
        
    }
}
