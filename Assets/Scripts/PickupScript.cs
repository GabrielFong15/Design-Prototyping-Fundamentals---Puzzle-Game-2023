using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    [SerializeField] private LayerMask pickupMask;
    [SerializeField] private Camera playerCam;
    [SerializeField] private Transform pickupTarget;
    [SerializeField] private float pickupRange;

    public Material emissiveMat;
    public Material objectiveBlockMat;
    public Material objectPropMat;
    private Rigidbody currentObject;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentObject == true)
            {
                currentObject.useGravity = true;
                currentObject = null;
                return;
            }

            Ray CameraRay = playerCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast(CameraRay, out RaycastHit HitInfo, pickupRange, pickupMask))
            {
                currentObject = HitInfo.rigidbody;
                currentObject.useGravity = false;
            }
        }
    }

    void FixedUpdate()
    {
        if (currentObject == true)
        {
            Vector3 DirectionToPoint = pickupTarget.position - currentObject.position;
            float DistanceToPoint = DirectionToPoint.magnitude;

            currentObject.velocity = DirectionToPoint * 16f * DistanceToPoint;
        }
    }
}