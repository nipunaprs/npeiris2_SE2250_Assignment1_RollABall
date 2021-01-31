using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Variables
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    //Camera follow script
    void LateUpdate ()
    {
        //Add the offset to get it exactly where we want. Offset is controlled in unity and can be adjusted.
        Vector3 desiredPosition = target.position + offset;
        //Smooth out the camera movement
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //Set the position to the smoothed position on the late update
        transform.position = smoothedPosition;
    }


}
