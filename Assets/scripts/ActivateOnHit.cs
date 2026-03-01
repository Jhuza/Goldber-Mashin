using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ActivateOnHit : MonoBehaviour
{
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Empieza congelado
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Palo"))
        {
            rb.isKinematic = false; // Se activa la física
        }
    }
}