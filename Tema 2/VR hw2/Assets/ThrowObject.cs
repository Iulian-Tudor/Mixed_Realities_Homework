using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ThrowObject : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private Rigidbody rb;
    private bool isGrabbing;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Keyboard.current.gKey.isPressed)
        {
            isGrabbing = true;
        }
        else if (isGrabbing && Keyboard.current.gKey.wasReleasedThisFrame)
        {
            isGrabbing = false;
            Throw();
        }
    }

    private void Throw()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        Vector3 throwDirection = transform.forward; // Adjust this to change the throw direction
        float throwForce = 5f; // Adjust this to change the throw force

        Debug.Log("in function");

        rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
    }
}