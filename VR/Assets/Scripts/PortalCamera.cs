using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{

    public Transform playerCam;
    public Transform endPortal;
    public Transform startPortal;

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = playerCam.position - startPortal.position;
        transform.position = endPortal.position + offset;

        float angularDiff = Quaternion.Angle(endPortal.rotation, startPortal.rotation);
        Quaternion portalRotDiff = Quaternion.AngleAxis(angularDiff, Vector3.up);
        Vector3 newCamDir = portalRotDiff * playerCam.forward;
        transform.rotation = Quaternion.LookRotation(newCamDir, Vector3.up);

        // transform.rotation = Quaternion.LookRotation(playerCam.forward, Vector3.up);
    }
}
