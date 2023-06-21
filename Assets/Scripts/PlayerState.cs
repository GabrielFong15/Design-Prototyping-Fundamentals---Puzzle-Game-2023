using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField] PlayerScaling PlayerScaling;
    [SerializeField] public int playerState;

    void Update()
    {
        playerState = PlayerScaling.playerState;
    }
}
