using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Ray g_ray = new Ray();
    private RaycastHit HitObject;
    public LayerMask layerToHit;
    public float rayLength = 10f;
    private bool isHit = false;
    public Transform carryPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     g_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(g_ray, out HitObject, rayLength, layerToHit))
        {
            if (HitObject.collider.tag == "Object")
            {
                isHit = true;
            }

        }
    }
}
