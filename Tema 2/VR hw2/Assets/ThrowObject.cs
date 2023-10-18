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

        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }

    private void OnDestroy()
    {
        grabInteractable.onSelectEntered.RemoveListener(OnGrab);
        grabInteractable.onSelectExited.RemoveListener(OnRelease);
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        isGrabbing = true;
        Debug.Log("Object grabbed");
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        isGrabbing = false;
        Debug.Log("Object released");
        Throw();
    }

    private void Update()
    {
        if (isGrabbing)
        {
            if (Keyboard.current.gKey.wasReleasedThisFrame)
            {
                Throw();
            }
        }
    }

    private void Throw()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        Vector3 throwDirection = transform.forward; // Adjust this to change the throw direction
        float throwForce = 10f; // Adjust this to change the throw force

        rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
    }
}