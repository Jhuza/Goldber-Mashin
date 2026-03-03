using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ActivateOnHit4Golpe : MonoBehaviour
{
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Empieza congelado
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cilindro"))
        {
            rb.isKinematic = false; // Se activa la física
        }
    }
}