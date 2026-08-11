using UnityEngine;
//ÉvÉåÉCÉÑÅ[Ç…í«è]ÇµÇ»Ç¢ãÖ
public class Sphere : MonoBehaviour
{
    public float speed = 3f;
    private Vector3 direction = Vector3.right;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 v = rb.linearVelocity;
        v.x = direction.x * speed;
        rb.linearVelocity = v;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = -direction;
        }
    }
}
