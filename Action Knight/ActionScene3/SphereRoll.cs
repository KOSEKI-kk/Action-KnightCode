using UnityEngine;
//ƒvƒŒƒCƒ„[‚É’Ç]‚·‚é‹…
public class SphereRoll : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 dir = (player.position - transform.position).normalized;

        Vector3 v = rb.linearVelocity;
        v.x = dir.x * speed;   // ‰¡‚¾‚¯’Ç]
        rb.linearVelocity = v;
    }
}
