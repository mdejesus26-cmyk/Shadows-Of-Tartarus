using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector2 movementInput;
    public int mp = 10;
    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        // Either the inputs A/D or the horizontal arrow keys can work.
        movementInput.y = Input.GetAxisRaw("Vertical");
        // Either the inputs W/S or the vertical arrow keys can work.
    }

    void FixedUpdate()
    {
        rb.velocity = movementInput * moveSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Key"))
        {
            hasKey = true;
        }
    }
}