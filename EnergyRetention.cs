using UnityEngine;

public class EnergyRetention : MonoBehaviour
{
    // Drag and angular drag factors.
    public float drag = 0.1f;
    public float angularDrag = 0.05f;

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component.
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Adjust drag and angular drag based on the sphere's speed.
        rb.drag = drag * rb.velocity.magnitude;
        rb.angularDrag = angularDrag * rb.angularVelocity.magnitude;
    }
}
