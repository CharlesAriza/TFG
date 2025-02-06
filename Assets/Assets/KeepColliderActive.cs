using UnityEngine;

public class KeepColliderActive : MonoBehaviour
{
    private Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (!col.enabled)
        {
            col.enabled = true; // Si el Collider se desactiva, lo reactiva
        }
    }
}
