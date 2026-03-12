using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector2 movementInput;
    public BattleManager battleScript;
    public GameObject level1;
    public GameObject level2;
    public GameObject key;
    public GameObject key2;
    public GameObject camera;

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
            camera.transform.position = new Vector3(transform.position.x, transform.position.y, -15.39f);
        }
         if (battleScript.inBattle == true)
        {
            /*rb.velocity = Vector3.zero;
             movementInput.x = 0;
             movementInput.y = 0;*/
             transform.position = new Vector3(1000, 500, transform.position.z);
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
            battleScript.inBattle = true;
            battleScript.battleScene.SetActive(true);
            key.SetActive(false);
        }
        else if (other.CompareTag("Key 2"))
        {
            battleScript.inBattle = true;
            battleScript.battleScene2.SetActive(true);
            key2.SetActive(false);
        }
    }

}