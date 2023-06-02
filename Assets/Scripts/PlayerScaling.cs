using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaling : MonoBehaviour
{
    public GameObject PlayerPressurePlate;
    int playerState = 2;

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
                collidedPlayer.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                
                playerState = 1;
               
            }
            else
            {
                collidedPlayer.transform.localScale = new Vector3(1f, 1f, 1f);
                playerState = 2;
            }
        }
       


    }

}
