using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_jump : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Collider2D col;
    [HideInInspector] public Vector3 Humanpose { get { return transform.position; } }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void push(Vector2 force)
    {
        rb.AddForce(force,ForceMode2D.Impulse);
    }
     public void activateRigidbody()
    {
        rb.isKinematic = false;
    }
    public void DeactivateRigidbody()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0f;
        rb.isKinematic = true;
    }


}
