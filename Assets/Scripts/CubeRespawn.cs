using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRespawn : MonoBehaviour
{
    public GameObject Block;
    public GameObject blockRespawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RespawnZone")
        {
            Block.transform.position = blockRespawnPoint.transform.position; 
        }
    }

}
