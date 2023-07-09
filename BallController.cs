using UnityEngine;

public class BallController : MonoBehaviour 
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    private void Awake()
    {
        Debug.Log(transform.position);
        // transform.position.y = 20;
        transform.position += new Vector3(0, 20, 0);
    }

    private void Update() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        Vector3 rotation = new Vector3(verticalInput, 0, -horizontalInput);
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
