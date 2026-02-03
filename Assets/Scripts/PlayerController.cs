using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector2 movementInput;
    public bool hasKey;
    public BattleManager battleScript;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (battleScript.inBattle == false)
        {
            movementInput.x = Input.GetAxisRaw("Horizontal");
            // Either the inputs A/D or the horizontal arrow keys can work.
            movementInput.y = Input.GetAxisRaw("Vertical");
            // Either the inputs W/S or the vertical arrow keys can work.
        }
         if (battleScript.inBattle == true)
        {
            rb.velocity = Vector3.zero;
             movementInput.x = 0;
             movementInput.y = 0;
             transform.position = new Vector3(1000, 500, transform.position.z);
             hasKey = false;
        }
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