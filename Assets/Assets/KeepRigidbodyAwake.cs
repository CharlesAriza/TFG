using UnityEngine;

public class KeepRigidbodyAwake : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.WakeUp(); // Evita que el Rigidbody pierda detección de colisiones
    }
}