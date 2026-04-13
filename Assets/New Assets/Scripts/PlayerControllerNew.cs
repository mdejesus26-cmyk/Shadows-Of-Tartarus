using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNew : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector2 movementInput;
    public GameObject camera;
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
        //camera.transform.position = new Vector3(transform.position.x, transform.position.y, -15.39f);
    }

    void FixedUpdate()
    {
        rb.velocity = movementInput * moveSpeed;
    }
}
