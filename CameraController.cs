using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // The zorbing ball
    public Vector3 offset; // The offset between the camera and the ball
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;
    
    private float currentZoom = 10f;

    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
    }

    private void LateUpdate()
    {
        transform.position = (target.position - transform.forward) + offset*currentZoom;
        transform.LookAt(target.position);
    }
}